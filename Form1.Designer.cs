namespace FuzzyDice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblOrderNumber = new Label();
            pnlOrderNumber = new Panel();
            txtOrderNumber = new TextBox();
            pnlCustomerDetails = new Panel();
            txtAddress3 = new TextBox();
            txtAddress2 = new TextBox();
            txtAddress1 = new TextBox();
            txtName = new TextBox();
            lblAddress = new Label();
            lblName = new Label();
            pnlOrder = new Panel();
            txtBB_Price = new TextBox();
            txtRB_Price = new TextBox();
            txtWB_Price = new TextBox();
            txtBB_Qty = new TextBox();
            txtRB_Qty = new TextBox();
            txtBB_Total = new TextBox();
            txtRB_Total = new TextBox();
            txtWB_Total = new TextBox();
            txtWB_Qty = new TextBox();
            chkBlueBlack = new CheckBox();
            chkRedBlack = new CheckBox();
            chkWhiteBlack = new CheckBox();
            lblTotals = new Label();
            lblPrice = new Label();
            lblQty = new Label();
            lblType = new Label();
            panel1 = new Panel();
            btnCalculate = new Button();
            lblOrderTotal = new Label();
            lblDiscount = new Label();
            lblShipping = new Label();
            lblTax = new Label();
            txtOrderTotal = new TextBox();
            txtDiscount = new TextBox();
            txtShipping = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            lblSubtotal = new Label();
            pnlOrderNumber.SuspendLayout();
            pnlCustomerDetails.SuspendLayout();
            pnlOrder.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(175, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 39);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fuzzy Dice";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderNumber.Location = new Point(14, 19);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(107, 18);
            lblOrderNumber.TabIndex = 1;
            lblOrderNumber.Text = "Order Number:";
            // 
            // pnlOrderNumber
            // 
            pnlOrderNumber.Controls.Add(txtOrderNumber);
            pnlOrderNumber.Controls.Add(lblOrderNumber);
            pnlOrderNumber.Location = new Point(12, 71);
            pnlOrderNumber.Name = "pnlOrderNumber";
            pnlOrderNumber.Size = new Size(231, 58);
            pnlOrderNumber.TabIndex = 2;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderNumber.Location = new Point(133, 17);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(79, 26);
            txtOrderNumber.TabIndex = 3;
            // 
            // pnlCustomerDetails
            // 
            pnlCustomerDetails.Controls.Add(txtAddress3);
            pnlCustomerDetails.Controls.Add(txtAddress2);
            pnlCustomerDetails.Controls.Add(txtAddress1);
            pnlCustomerDetails.Controls.Add(txtName);
            pnlCustomerDetails.Controls.Add(lblAddress);
            pnlCustomerDetails.Controls.Add(lblName);
            pnlCustomerDetails.Location = new Point(12, 144);
            pnlCustomerDetails.Name = "pnlCustomerDetails";
            pnlCustomerDetails.Size = new Size(486, 143);
            pnlCustomerDetails.TabIndex = 3;
            // 
            // txtAddress3
            // 
            txtAddress3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress3.Location = new Point(131, 102);
            txtAddress3.Name = "txtAddress3";
            txtAddress3.PlaceholderText = "Customer 's Address Line 3";
            txtAddress3.Size = new Size(329, 26);
            txtAddress3.TabIndex = 5;
            // 
            // txtAddress2
            // 
            txtAddress2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress2.Location = new Point(131, 73);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.PlaceholderText = "Customer's Address Line 2";
            txtAddress2.Size = new Size(329, 26);
            txtAddress2.TabIndex = 5;
            // 
            // txtAddress1
            // 
            txtAddress1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress1.Location = new Point(131, 44);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.PlaceholderText = "Customer's Address Line 1";
            txtAddress1.Size = new Size(329, 26);
            txtAddress1.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(131, 15);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Customer's Name";
            txtName.Size = new Size(329, 26);
            txtName.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(14, 47);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 18);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(14, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 18);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // pnlOrder
            // 
            pnlOrder.Controls.Add(txtBB_Price);
            pnlOrder.Controls.Add(txtRB_Price);
            pnlOrder.Controls.Add(txtWB_Price);
            pnlOrder.Controls.Add(txtBB_Qty);
            pnlOrder.Controls.Add(txtRB_Qty);
            pnlOrder.Controls.Add(txtBB_Total);
            pnlOrder.Controls.Add(txtRB_Total);
            pnlOrder.Controls.Add(txtWB_Total);
            pnlOrder.Controls.Add(txtWB_Qty);
            pnlOrder.Controls.Add(chkBlueBlack);
            pnlOrder.Controls.Add(chkRedBlack);
            pnlOrder.Controls.Add(chkWhiteBlack);
            pnlOrder.Controls.Add(lblTotals);
            pnlOrder.Controls.Add(lblPrice);
            pnlOrder.Controls.Add(lblQty);
            pnlOrder.Controls.Add(lblType);
            pnlOrder.Location = new Point(12, 293);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new Size(486, 139);
            pnlOrder.TabIndex = 6;
            // 
            // txtBB_Price
            // 
            txtBB_Price.BorderStyle = BorderStyle.None;
            txtBB_Price.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBB_Price.Location = new Point(258, 106);
            txtBB_Price.Name = "txtBB_Price";
            txtBB_Price.ReadOnly = true;
            txtBB_Price.Size = new Size(86, 19);
            txtBB_Price.TabIndex = 9;
            // 
            // txtRB_Price
            // 
            txtRB_Price.BorderStyle = BorderStyle.None;
            txtRB_Price.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRB_Price.Location = new Point(258, 76);
            txtRB_Price.Name = "txtRB_Price";
            txtRB_Price.ReadOnly = true;
            txtRB_Price.Size = new Size(86, 19);
            txtRB_Price.TabIndex = 9;
            // 
            // txtWB_Price
            // 
            txtWB_Price.BorderStyle = BorderStyle.None;
            txtWB_Price.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWB_Price.Location = new Point(258, 42);
            txtWB_Price.Name = "txtWB_Price";
            txtWB_Price.ReadOnly = true;
            txtWB_Price.Size = new Size(86, 19);
            txtWB_Price.TabIndex = 9;
            // 
            // txtBB_Qty
            // 
            txtBB_Qty.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBB_Qty.Location = new Point(133, 103);
            txtBB_Qty.Name = "txtBB_Qty";
            txtBB_Qty.Size = new Size(105, 26);
            txtBB_Qty.TabIndex = 3;
            txtBB_Qty.TextChanged += txtWB_Qty_TextChanged;
            txtBB_Qty.KeyPress += txtWB_Qty_KeyPress;
            // 
            // txtRB_Qty
            // 
            txtRB_Qty.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRB_Qty.Location = new Point(133, 71);
            txtRB_Qty.Name = "txtRB_Qty";
            txtRB_Qty.Size = new Size(105, 26);
            txtRB_Qty.TabIndex = 3;
            txtRB_Qty.TextChanged += txtWB_Qty_TextChanged;
            txtRB_Qty.KeyPress += txtWB_Qty_KeyPress;
            // 
            // txtBB_Total
            // 
            txtBB_Total.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBB_Total.Location = new Point(359, 103);
            txtBB_Total.Name = "txtBB_Total";
            txtBB_Total.ReadOnly = true;
            txtBB_Total.Size = new Size(105, 26);
            txtBB_Total.TabIndex = 3;
            // 
            // txtRB_Total
            // 
            txtRB_Total.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRB_Total.Location = new Point(359, 71);
            txtRB_Total.Name = "txtRB_Total";
            txtRB_Total.ReadOnly = true;
            txtRB_Total.Size = new Size(105, 26);
            txtRB_Total.TabIndex = 3;
            // 
            // txtWB_Total
            // 
            txtWB_Total.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWB_Total.Location = new Point(359, 39);
            txtWB_Total.Name = "txtWB_Total";
            txtWB_Total.ReadOnly = true;
            txtWB_Total.Size = new Size(105, 26);
            txtWB_Total.TabIndex = 3;
            // 
            // txtWB_Qty
            // 
            txtWB_Qty.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWB_Qty.Location = new Point(133, 39);
            txtWB_Qty.Name = "txtWB_Qty";
            txtWB_Qty.Size = new Size(105, 26);
            txtWB_Qty.TabIndex = 3;
            txtWB_Qty.TextChanged += txtWB_Qty_TextChanged;
            txtWB_Qty.KeyPress += txtWB_Qty_KeyPress;
            // 
            // chkBlueBlack
            // 
            chkBlueBlack.AutoSize = true;
            chkBlueBlack.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkBlueBlack.Location = new Point(14, 105);
            chkBlueBlack.Name = "chkBlueBlack";
            chkBlueBlack.Size = new Size(93, 22);
            chkBlueBlack.TabIndex = 8;
            chkBlueBlack.Text = "Blue/Black";
            chkBlueBlack.UseVisualStyleBackColor = true;
            chkBlueBlack.CheckedChanged += chkBlueBlack_CheckedChanged;
            // 
            // chkRedBlack
            // 
            chkRedBlack.AutoSize = true;
            chkRedBlack.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkRedBlack.Location = new Point(14, 73);
            chkRedBlack.Name = "chkRedBlack";
            chkRedBlack.Size = new Size(91, 22);
            chkRedBlack.TabIndex = 8;
            chkRedBlack.Text = "Red/Black";
            chkRedBlack.UseVisualStyleBackColor = true;
            chkRedBlack.CheckedChanged += chkRedBlack_CheckedChanged;
            // 
            // chkWhiteBlack
            // 
            chkWhiteBlack.AutoSize = true;
            chkWhiteBlack.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkWhiteBlack.Location = new Point(14, 43);
            chkWhiteBlack.Name = "chkWhiteBlack";
            chkWhiteBlack.Size = new Size(103, 22);
            chkWhiteBlack.TabIndex = 8;
            chkWhiteBlack.Text = "White/Black";
            chkWhiteBlack.UseVisualStyleBackColor = true;
            chkWhiteBlack.CheckedChanged += chkWhiteBlack_CheckedChanged;
            // 
            // lblTotals
            // 
            lblTotals.AutoSize = true;
            lblTotals.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotals.Location = new Point(359, 11);
            lblTotals.Name = "lblTotals";
            lblTotals.Size = new Size(53, 18);
            lblTotals.TabIndex = 7;
            lblTotals.Text = "Totals:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(258, 11);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 18);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQty.Location = new Point(133, 11);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(68, 18);
            lblQty.TabIndex = 7;
            lblQty.Text = "Quantity:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblType.Location = new Point(14, 11);
            lblType.Name = "lblType";
            lblType.Size = new Size(47, 18);
            lblType.TabIndex = 7;
            lblType.Text = "Type:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCalculate);
            panel1.Controls.Add(lblOrderTotal);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblShipping);
            panel1.Controls.Add(lblTax);
            panel1.Controls.Add(txtOrderTotal);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtShipping);
            panel1.Controls.Add(txtTax);
            panel1.Controls.Add(txtSubtotal);
            panel1.Controls.Add(lblSubtotal);
            panel1.Location = new Point(258, 438);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 240);
            panel1.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(113, 191);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 42);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderTotal.Location = new Point(28, 162);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(46, 18);
            lblOrderTotal.TabIndex = 7;
            lblOrderTotal.Text = "Total:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.Location = new Point(28, 126);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(68, 18);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = "Discount:";
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblShipping.Location = new Point(28, 90);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(65, 18);
            lblShipping.TabIndex = 7;
            lblShipping.Text = "Shipping:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTax.Location = new Point(28, 54);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(39, 18);
            lblTax.TabIndex = 7;
            lblTax.Text = "Tax:";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderTotal.Location = new Point(113, 159);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(105, 26);
            txtOrderTotal.TabIndex = 3;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscount.Location = new Point(113, 123);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(105, 26);
            txtDiscount.TabIndex = 3;
            // 
            // txtShipping
            // 
            txtShipping.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipping.Location = new Point(113, 87);
            txtShipping.Name = "txtShipping";
            txtShipping.ReadOnly = true;
            txtShipping.Size = new Size(105, 26);
            txtShipping.TabIndex = 3;
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTax.Location = new Point(113, 51);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(105, 26);
            txtTax.TabIndex = 3;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubtotal.Location = new Point(113, 15);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(105, 26);
            txtSubtotal.TabIndex = 3;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(28, 18);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(70, 18);
            lblSubtotal.TabIndex = 7;
            lblSubtotal.Text = "Subtotal: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 689);
            Controls.Add(panel1);
            Controls.Add(pnlOrder);
            Controls.Add(pnlCustomerDetails);
            Controls.Add(pnlOrderNumber);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fuzzy Dice";
            Load += Form1_Load;
            pnlOrderNumber.ResumeLayout(false);
            pnlOrderNumber.PerformLayout();
            pnlCustomerDetails.ResumeLayout(false);
            pnlCustomerDetails.PerformLayout();
            pnlOrder.ResumeLayout(false);
            pnlOrder.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblOrderNumber;
        private Panel pnlOrderNumber;
        private TextBox txtOrderNumber;
        private Panel pnlCustomerDetails;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtAddress2;
        private TextBox txtAddress1;
        private Label lblAddress;
        private TextBox txtAddress3;
        private Panel pnlOrder;
        private CheckBox chkWhiteBlack;
        private Label lblType;
        private CheckBox chkBlueBlack;
        private CheckBox chkRedBlack;
        private TextBox txtWB_Qty;
        private Label lblQty;
        private TextBox txtBB_Qty;
        private TextBox txtRB_Qty;
        private Label lblPrice;
        private TextBox txtWB_Price;
        private TextBox txtBB_Price;
        private TextBox txtBB_Total;
        private TextBox txtRB_Total;
        private TextBox txtWB_Total;
        private Label lblTotals;
        private Panel panel1;
        private Label lblOrderTotal;
        private Label lblDiscount;
        private Label lblShipping;
        private Label lblTax;
        private Label lblSubtotal;
        private TextBox txtOrderTotal;
        private TextBox txtDiscount;
        private TextBox txtShipping;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Button btnCalculate;
        private TextBox txtRB_Price;
    }
}