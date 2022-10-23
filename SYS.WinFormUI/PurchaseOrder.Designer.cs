namespace SYS.WinFormUI
{
    partial class Form_PurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_oderDate = new System.Windows.Forms.Label();
            this.comboBox_currencyID = new System.Windows.Forms.ComboBox();
            this.textBox_discountRate = new System.Windows.Forms.TextBox();
            this.label_discountRate = new System.Windows.Forms.Label();
            this.textBox_grandtotal = new System.Windows.Forms.TextBox();
            this.label_grandTotal = new System.Windows.Forms.Label();
            this.textBox_unitPrice = new System.Windows.Forms.TextBox();
            this.label_unitPrice = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.label_employeeID = new System.Windows.Forms.Label();
            this.label_supplierName = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_purchaseOrderID = new System.Windows.Forms.TextBox();
            this.dateTimePicker_orderDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label_deliveryDate = new System.Windows.Forms.Label();
            this.dateTimePicker_revDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label_rev_DeliveryDate = new System.Windows.Forms.Label();
            this.comboBox_firmName = new System.Windows.Forms.ComboBox();
            this.comboBox_employeeID = new System.Windows.Forms.ComboBox();
            this.comboBox_stockID = new System.Windows.Forms.ComboBox();
            this.label_stockID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vatRate = new System.Windows.Forms.TextBox();
            this.textBox_subtotal = new System.Windows.Forms.TextBox();
            this.label_purchaseOrderID = new System.Windows.Forms.Label();
            this.textBoxdiscountAmount = new System.Windows.Forms.TextBox();
            this.textBox_vatAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_oderDate
            // 
            this.label_oderDate.AutoSize = true;
            this.label_oderDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_oderDate.Location = new System.Drawing.Point(293, 12);
            this.label_oderDate.Name = "label_oderDate";
            this.label_oderDate.Size = new System.Drawing.Size(90, 19);
            this.label_oderDate.TabIndex = 120;
            this.label_oderDate.Text = "Order Date";
            // 
            // comboBox_currencyID
            // 
            this.comboBox_currencyID.FormattingEnabled = true;
            this.comboBox_currencyID.Location = new System.Drawing.Point(495, 166);
            this.comboBox_currencyID.Name = "comboBox_currencyID";
            this.comboBox_currencyID.Size = new System.Drawing.Size(122, 28);
            this.comboBox_currencyID.TabIndex = 119;
            // 
            // textBox_discountRate
            // 
            this.textBox_discountRate.Location = new System.Drawing.Point(623, 200);
            this.textBox_discountRate.Name = "textBox_discountRate";
            this.textBox_discountRate.Size = new System.Drawing.Size(39, 27);
            this.textBox_discountRate.TabIndex = 117;
            // 
            // label_discountRate
            // 
            this.label_discountRate.AutoSize = true;
            this.label_discountRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_discountRate.Location = new System.Drawing.Point(486, 204);
            this.label_discountRate.Name = "label_discountRate";
            this.label_discountRate.Size = new System.Drawing.Size(131, 19);
            this.label_discountRate.TabIndex = 116;
            this.label_discountRate.Text = "Discount Rate %";
            // 
            // textBox_grandtotal
            // 
            this.textBox_grandtotal.Enabled = false;
            this.textBox_grandtotal.Location = new System.Drawing.Point(623, 266);
            this.textBox_grandtotal.Name = "textBox_grandtotal";
            this.textBox_grandtotal.Size = new System.Drawing.Size(159, 27);
            this.textBox_grandtotal.TabIndex = 115;
            // 
            // label_grandTotal
            // 
            this.label_grandTotal.AutoSize = true;
            this.label_grandTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_grandTotal.Location = new System.Drawing.Point(526, 274);
            this.label_grandTotal.Name = "label_grandTotal";
            this.label_grandTotal.Size = new System.Drawing.Size(91, 19);
            this.label_grandTotal.TabIndex = 114;
            this.label_grandTotal.Text = "Grand Total";
            // 
            // textBox_unitPrice
            // 
            this.textBox_unitPrice.Location = new System.Drawing.Point(367, 166);
            this.textBox_unitPrice.Name = "textBox_unitPrice";
            this.textBox_unitPrice.Size = new System.Drawing.Size(126, 27);
            this.textBox_unitPrice.TabIndex = 113;
            this.textBox_unitPrice.TextChanged += new System.EventHandler(this.textBox_unitPrice_TextChanged);
            // 
            // label_unitPrice
            // 
            this.label_unitPrice.AutoSize = true;
            this.label_unitPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_unitPrice.Location = new System.Drawing.Point(280, 170);
            this.label_unitPrice.Name = "label_unitPrice";
            this.label_unitPrice.Size = new System.Drawing.Size(81, 19);
            this.label_unitPrice.TabIndex = 112;
            this.label_unitPrice.Text = "Unit Price";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(234, 295);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(103, 38);
            this.button_update.TabIndex = 111;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(125, 295);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 38);
            this.button_delete.TabIndex = 110;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(16, 295);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(103, 38);
            this.button_ınsert.TabIndex = 109;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click);
            // 
            // label_employeeID
            // 
            this.label_employeeID.AutoSize = true;
            this.label_employeeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_employeeID.Location = new System.Drawing.Point(549, 12);
            this.label_employeeID.Name = "label_employeeID";
            this.label_employeeID.Size = new System.Drawing.Size(103, 19);
            this.label_employeeID.TabIndex = 106;
            this.label_employeeID.Text = "Employee ID";
            // 
            // label_supplierName
            // 
            this.label_supplierName.AutoSize = true;
            this.label_supplierName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_supplierName.Location = new System.Drawing.Point(13, 45);
            this.label_supplierName.Name = "label_supplierName";
            this.label_supplierName.Size = new System.Drawing.Size(116, 19);
            this.label_supplierName.TabIndex = 104;
            this.label_supplierName.Text = "Supplier Name";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(142, 166);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(132, 27);
            this.textBox_quantity.TabIndex = 103;
            this.textBox_quantity.TextChanged += new System.EventHandler(this.textBox_quantity_TextChanged);
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_quantity.Location = new System.Drawing.Point(16, 174);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(69, 19);
            this.label_quantity.TabIndex = 102;
            this.label_quantity.Text = "Quantity";
            this.label_quantity.Click += new System.EventHandler(this.label_quantity_Click);
            // 
            // textBox_purchaseOrderID
            // 
            this.textBox_purchaseOrderID.Enabled = false;
            this.textBox_purchaseOrderID.Location = new System.Drawing.Point(142, 8);
            this.textBox_purchaseOrderID.Name = "textBox_purchaseOrderID";
            this.textBox_purchaseOrderID.Size = new System.Drawing.Size(132, 27);
            this.textBox_purchaseOrderID.TabIndex = 101;
            // 
            // dateTimePicker_orderDate
            // 
            this.dateTimePicker_orderDate.Location = new System.Drawing.Point(389, 8);
            this.dateTimePicker_orderDate.Name = "dateTimePicker_orderDate";
            this.dateTimePicker_orderDate.Size = new System.Drawing.Size(139, 27);
            this.dateTimePicker_orderDate.TabIndex = 123;
            this.dateTimePicker_orderDate.ValueChanged += new System.EventHandler(this.dateTimePicker_orderDate_ValueChanged);
            // 
            // dateTimePicker_deliveryDate
            // 
            this.dateTimePicker_deliveryDate.Location = new System.Drawing.Point(142, 74);
            this.dateTimePicker_deliveryDate.Name = "dateTimePicker_deliveryDate";
            this.dateTimePicker_deliveryDate.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker_deliveryDate.TabIndex = 125;
            // 
            // label_deliveryDate
            // 
            this.label_deliveryDate.AutoSize = true;
            this.label_deliveryDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_deliveryDate.Location = new System.Drawing.Point(12, 80);
            this.label_deliveryDate.Name = "label_deliveryDate";
            this.label_deliveryDate.Size = new System.Drawing.Size(107, 19);
            this.label_deliveryDate.TabIndex = 124;
            this.label_deliveryDate.Text = "Delivery Date";
            // 
            // dateTimePicker_revDeliveryDate
            // 
            this.dateTimePicker_revDeliveryDate.Location = new System.Drawing.Point(576, 74);
            this.dateTimePicker_revDeliveryDate.Name = "dateTimePicker_revDeliveryDate";
            this.dateTimePicker_revDeliveryDate.Size = new System.Drawing.Size(206, 27);
            this.dateTimePicker_revDeliveryDate.TabIndex = 127;
            // 
            // label_rev_DeliveryDate
            // 
            this.label_rev_DeliveryDate.AutoSize = true;
            this.label_rev_DeliveryDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_rev_DeliveryDate.Location = new System.Drawing.Point(432, 80);
            this.label_rev_DeliveryDate.Name = "label_rev_DeliveryDate";
            this.label_rev_DeliveryDate.Size = new System.Drawing.Size(138, 19);
            this.label_rev_DeliveryDate.TabIndex = 126;
            this.label_rev_DeliveryDate.Text = "Rev.Delivery Date";
            // 
            // comboBox_firmName
            // 
            this.comboBox_firmName.FormattingEnabled = true;
            this.comboBox_firmName.Location = new System.Drawing.Point(142, 40);
            this.comboBox_firmName.Name = "comboBox_firmName";
            this.comboBox_firmName.Size = new System.Drawing.Size(640, 28);
            this.comboBox_firmName.TabIndex = 128;
            // 
            // comboBox_employeeID
            // 
            this.comboBox_employeeID.FormattingEnabled = true;
            this.comboBox_employeeID.Location = new System.Drawing.Point(658, 8);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(124, 28);
            this.comboBox_employeeID.TabIndex = 129;
            // 
            // comboBox_stockID
            // 
            this.comboBox_stockID.FormattingEnabled = true;
            this.comboBox_stockID.Location = new System.Drawing.Point(142, 132);
            this.comboBox_stockID.Name = "comboBox_stockID";
            this.comboBox_stockID.Size = new System.Drawing.Size(640, 28);
            this.comboBox_stockID.TabIndex = 131;
            this.comboBox_stockID.SelectedIndexChanged += new System.EventHandler(this.comboBox_stockID_SelectedIndexChanged);
            this.comboBox_stockID.SelectionChangeCommitted += new System.EventHandler(this.comboBox_stockID_SelectionChangeCommitted);
            this.comboBox_stockID.SelectedValueChanged += new System.EventHandler(this.comboBox_stockID_SelectedValueChanged);
            this.comboBox_stockID.TextChanged += new System.EventHandler(this.comboBox_stockID_TextChanged);
            // 
            // label_stockID
            // 
            this.label_stockID.AutoSize = true;
            this.label_stockID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_stockID.Location = new System.Drawing.Point(13, 136);
            this.label_stockID.Name = "label_stockID";
            this.label_stockID.Size = new System.Drawing.Size(72, 19);
            this.label_stockID.TabIndex = 130;
            this.label_stockID.Text = "Stock ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(527, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 114;
            this.label1.Text = "Vat Rate %";
            // 
            // textBox_vatRate
            // 
            this.textBox_vatRate.Location = new System.Drawing.Point(623, 233);
            this.textBox_vatRate.Name = "textBox_vatRate";
            this.textBox_vatRate.Size = new System.Drawing.Size(39, 27);
            this.textBox_vatRate.TabIndex = 115;
            // 
            // textBox_subtotal
            // 
            this.textBox_subtotal.Enabled = false;
            this.textBox_subtotal.Location = new System.Drawing.Point(623, 167);
            this.textBox_subtotal.Name = "textBox_subtotal";
            this.textBox_subtotal.Size = new System.Drawing.Size(159, 27);
            this.textBox_subtotal.TabIndex = 132;
            this.textBox_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_purchaseOrderID
            // 
            this.label_purchaseOrderID.AutoSize = true;
            this.label_purchaseOrderID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_purchaseOrderID.Location = new System.Drawing.Point(16, 14);
            this.label_purchaseOrderID.Name = "label_purchaseOrderID";
            this.label_purchaseOrderID.Size = new System.Drawing.Size(54, 19);
            this.label_purchaseOrderID.TabIndex = 133;
            this.label_purchaseOrderID.Text = "PO ID";
            // 
            // textBoxdiscountAmount
            // 
            this.textBoxdiscountAmount.Location = new System.Drawing.Point(668, 200);
            this.textBoxdiscountAmount.Name = "textBoxdiscountAmount";
            this.textBoxdiscountAmount.Size = new System.Drawing.Size(114, 27);
            this.textBoxdiscountAmount.TabIndex = 135;
            // 
            // textBox_vatAmount
            // 
            this.textBox_vatAmount.Location = new System.Drawing.Point(668, 233);
            this.textBox_vatAmount.Name = "textBox_vatAmount";
            this.textBox_vatAmount.Size = new System.Drawing.Size(114, 27);
            this.textBox_vatAmount.TabIndex = 134;
            // 
            // Form_PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.textBoxdiscountAmount);
            this.Controls.Add(this.textBox_vatAmount);
            this.Controls.Add(this.label_purchaseOrderID);
            this.Controls.Add(this.textBox_subtotal);
            this.Controls.Add(this.comboBox_stockID);
            this.Controls.Add(this.label_stockID);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.comboBox_firmName);
            this.Controls.Add(this.dateTimePicker_revDeliveryDate);
            this.Controls.Add(this.label_rev_DeliveryDate);
            this.Controls.Add(this.dateTimePicker_deliveryDate);
            this.Controls.Add(this.label_deliveryDate);
            this.Controls.Add(this.dateTimePicker_orderDate);
            this.Controls.Add(this.label_oderDate);
            this.Controls.Add(this.comboBox_currencyID);
            this.Controls.Add(this.textBox_discountRate);
            this.Controls.Add(this.label_discountRate);
            this.Controls.Add(this.textBox_vatRate);
            this.Controls.Add(this.textBox_grandtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_grandTotal);
            this.Controls.Add(this.textBox_unitPrice);
            this.Controls.Add(this.label_unitPrice);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.label_employeeID);
            this.Controls.Add(this.label_supplierName);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.textBox_purchaseOrderID);
            this.Name = "Form_PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.Form_PurchaseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_oderDate;
        private ComboBox comboBox_currencyID;
        private TextBox textBox_discountRate;
        private Label label_discountRate;
        private TextBox textBox_grandtotal;
        private Label label_grandTotal;
        private TextBox textBox_unitPrice;
        private Label label_unitPrice;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private Label label_employeeID;
        private Label label_supplierName;
        private TextBox textBox_quantity;
        private Label label_quantity;
        private TextBox textBox_purchaseOrderID;
        private DateTimePicker dateTimePicker_orderDate;
        private DateTimePicker dateTimePicker_deliveryDate;
        private Label label_deliveryDate;
        private DateTimePicker dateTimePicker_revDeliveryDate;
        private Label label_rev_DeliveryDate;
        private ComboBox comboBox_firmName;
        private ComboBox comboBox_employeeID;
        private ComboBox comboBox_stockID;
        private Label label_stockID;
        private Label label1;
        private TextBox textBox_vatRate;
        private TextBox textBox_subtotal;
        private Label label_purchaseOrderID;
        private TextBox textBoxdiscountAmount;
        private TextBox textBox_vatAmount;
    }
}