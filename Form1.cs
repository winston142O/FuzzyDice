using System.Diagnostics.Eventing.Reader;

namespace FuzzyDice
{
    public partial class Form1 : Form
    {
        // Definicion de variables y su valor inicial
        private double OrderTotal = 0.00;
        private double Subtotal = 0.00;
        private double taxTotal = 0.00;
        private double shipping;
        private double discount = 0.00;
        private int diceQty;
        private double wbPrice = 6.25;
        private double rbPrice = 5.00;
        private double bbPrice = 7.50;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcDicePrice(int qty, double price, TextBox objTextBox)
        {            
            // calcular precio de los dados
            double diceTotal = qty * price;
            objTextBox.Text = String.Format("${0:F2}", diceTotal);
        }

        private void CalcShipping()
        {
            diceQty = 0;
            int wbQty = 0;
            int rbQty = 0;
            int bbQty = 0;

            if (txtWB_Qty.Text != "")
            {
                wbQty = Convert.ToInt32(txtWB_Qty.Text);
            }
            if (txtRB_Qty.Text != "")
            {
                rbQty = Convert.ToInt32(txtRB_Qty.Text);
            }
            if (txtBB_Qty.Text != "")
            {
                bbQty = Convert.ToInt32(txtBB_Qty.Text);
            }
            diceQty += wbQty + rbQty + bbQty;
            if (diceQty > 0 && diceQty <= 20)
            {
                shipping = 1.50;
            }
            else if (diceQty > 20)
            {
                shipping = 0.00;
            }
            txtShipping.Text = String.Format("${0:F2}", shipping);
        }

        private void AddToSubtotal(TextBox DiceSubtotal, TextBox Total)
        {            
            string valorTexto = DiceSubtotal.Text;
            valorTexto = valorTexto.Replace("$", "");
            double subtotal = Convert.ToDouble(valorTexto);
            Subtotal += subtotal;
            Total.Text = String.Format("${0:F2}", Subtotal);
        }

        private void CalcTaxDiscount()
        {
            // a�adir impuestos
            double taxRate = 0.05;
            double TaxValue = Subtotal * taxRate;
            taxTotal = TaxValue;
            txtTax.Text = String.Format("${0:F2}", taxTotal);
            // Calcular descuento
            double discountRate = 0.07;
            if (Subtotal > 500.00)
            {
                discount = Subtotal * discountRate;
                MessageBox.Show("7% discount will be applied!", "Discount Offer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Text = String.Format("${0:F2}", discount);
            }
            else
            {
                txtDiscount.Text = String.Format("${0:F2}", discount);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // establecer precios
            txtWB_Price.Text = String.Format("${0:F2}", wbPrice);
            txtRB_Price.Text = String.Format("${0:F2}", rbPrice);
            txtBB_Price.Text = String.Format("${0:F2}", bbPrice);
            txtWB_Total.Text = String.Format("${0:F2}", "0.00");
            txtRB_Total.Text = String.Format("${0:F2}", "0.00");
            txtBB_Total.Text = String.Format("${0:F2}", "0.00");
            // desactivar entradas
            txtWB_Qty.Enabled = false;
            txtRB_Qty.Enabled = false;
            txtBB_Qty.Enabled = false;
        }

        // metodo para introducir la cantidad de dados
        private void txtWB_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solamente entrada numerica y backspace
            if (e.KeyChar >= Convert.ToChar(48) && e.KeyChar <= Convert.ToChar(59) || e.KeyChar == Convert.ToChar(8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtWB_Qty_TextChanged(object sender, EventArgs e)
        {
            int itemQty;

            if (txtWB_Qty.Focused)
            {
                try
                {
                    itemQty = Convert.ToInt32(txtWB_Qty.Text);
                    CalcDicePrice(itemQty, wbPrice, txtWB_Total);

                }
                catch (Exception error)
                {
                    txtWB_Total.Text = String.Format("${0:F2}", "0.00");
                }
            }
            else if (txtRB_Qty.Focused)
            {
                try
                {
                    itemQty = Convert.ToInt32(txtRB_Qty.Text);
                    CalcDicePrice(itemQty, rbPrice, txtRB_Total);
                }
                catch (Exception error)
                {
                    txtRB_Total.Text = String.Format("${0:F2}", "0.00");
                }
            }
            else if (txtBB_Qty.Focused)
            {
                try
                {
                    itemQty = Convert.ToInt32(txtBB_Qty.Text);
                    CalcDicePrice(itemQty, bbPrice, txtBB_Total);
                }
                catch (Exception error)
                {
                    txtBB_Total.Text = String.Format("${0:F2}", "0.00");
                }
            }
        }

        private void chkWhiteBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhiteBlack.Checked)
            {
                txtWB_Qty.Enabled = true;
            }
            else
            {
                txtWB_Qty.Enabled = false;
            }
        }

        private void chkRedBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedBlack.Checked)
            {
                txtRB_Qty.Enabled = true;
            }
            else
            {
                txtRB_Qty.Enabled = false;
            }
        }

        private void chkBlueBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlueBlack.Checked)
            {
                txtBB_Qty.Enabled = true;
            }
            else
            {
                txtBB_Qty.Enabled = false;
            }
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            
        }        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // si se ha ingresado el nombre y al menos 1 direccion de envio
            if (txtName.Text != "" && (txtAddress1.Text != "" || txtAddress2.Text != "" || txtAddress3.Text != ""))
            {
                // A�adir subtotales
                AddToSubtotal(txtWB_Total, txtSubtotal);
                AddToSubtotal(txtRB_Total, txtSubtotal);
                AddToSubtotal(txtBB_Total, txtSubtotal);
                // Calcular Impuesto y descuento
                CalcTaxDiscount();
                // Asignar envio
                CalcShipping();
                txtDiceTotal.Text = diceQty.ToString();
                // Mostrar Total

            }
            else
            {
                // mostrar error
                MessageBox.Show("Debe ingresar correctamente su nombre completo y direcci�n ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}