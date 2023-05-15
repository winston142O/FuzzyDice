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

        private void verifyShipping()
        {
            if (diceQty >= 1 && diceQty <= 20)
            {
                shipping = 1.50;
            }
            else
            {
                shipping = 0.00;
            }
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
            // añadir impuestos
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
                txtDiscount.Text = String.Format("(${0:F2})", discount);
            }
        }

        private void CalcTotal()
        {
            OrderTotal += Subtotal + taxTotal + shipping;
            if (discount > 0)
            {
                OrderTotal -= discount;
            }
            txtOrderTotal.Text = String.Format("${0:F2}", OrderTotal);
        }

        private void genOrderNumber()
        {
            Random random = new Random();
            int orderNumber = random.Next(1000, 10000);
            txtOrderNumber.Text = orderNumber.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // generar numero de orden
            genOrderNumber();
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
            // si se pulsa enter
            else if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = false;
                if (txtWB_Qty.Focused)
                {
                    DialogResult resp = MessageBox.Show(String.Format("¿Deseas agregar el monto {0:F2} al total de esta orden?", txtWB_Total.Text), "Confirmar", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        AddToSubtotal(txtWB_Total, txtSubtotal);
                    }
                    else if (resp == DialogResult.No)
                    {
                        // nada
                    }
                }
                else if (txtRB_Qty.Focused)
                {
                    DialogResult resp = MessageBox.Show(String.Format("¿Deseas agregar el monto {0:F2} al total de esta orden?", txtRB_Total.Text), "Confirmar", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        AddToSubtotal(txtRB_Total, txtSubtotal);
                    }
                    else if (resp == DialogResult.No)
                    {
                        // nada
                    }
                }
                else if (txtBB_Qty.Focused)
                {
                    DialogResult resp = MessageBox.Show(String.Format("¿Deseas agregar el monto {0:F2} al total de esta orden?", txtBB_Total.Text), "Confirmar", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        AddToSubtotal(txtBB_Total, txtSubtotal);
                    }
                    else if (resp == DialogResult.No)
                    {
                        // nada
                    }
                }
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
                // Añadir subtotales
                AddToSubtotal(txtWB_Total, txtSubtotal);
                AddToSubtotal(txtRB_Total, txtSubtotal);
                AddToSubtotal(txtBB_Total, txtSubtotal);
                // Calcular Impuesto y descuento
                CalcTaxDiscount();
                // Asignar envio
                CalcShipping();
                // Mostrar Total
                CalcTotal();
            }
            else
            {
                // mostrar error
                MessageBox.Show("Debe ingresar correctamente su nombre completo y dirección ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Asignar envio
            // shipping not working
            verifyShipping();
            txtShipping.Text = String.Format("${0:F2}", shipping);

        }
    }
}