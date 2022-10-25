namespace SYS.WinFormUI
{
    partial class Form_Stocks
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
            this.dataGridView_stocks = new System.Windows.Forms.DataGridView();
            this.textBox_name2 = new System.Windows.Forms.TextBox();
            this.label_name2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_purchasePrice = new System.Windows.Forms.TextBox();
            this.label_purchasePrice = new System.Windows.Forms.Label();
            this.textBox_salePrice = new System.Windows.Forms.TextBox();
            this.label_salePrice = new System.Windows.Forms.Label();
            this.textBox_vatRate = new System.Windows.Forms.TextBox();
            this.label_vatRate = new System.Windows.Forms.Label();
            this.textBox_discountRate = new System.Windows.Forms.TextBox();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_unit = new System.Windows.Forms.Label();
            this.comboBox_stock_UnitID = new System.Windows.Forms.ComboBox();
            this.comboBox_currencyID = new System.Windows.Forms.ComboBox();
            this.label_currency = new System.Windows.Forms.Label();
            this.comboBox_stockID = new System.Windows.Forms.ComboBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_before = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.dataGridView_stocktransferbody = new System.Windows.Forms.DataGridView();
            this.label_stockID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stocktransferbody)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stocks
            // 
            this.dataGridView_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stocks.Location = new System.Drawing.Point(12, 207);
            this.dataGridView_stocks.Name = "dataGridView_stocks";
            this.dataGridView_stocks.RowHeadersWidth = 51;
            this.dataGridView_stocks.RowTemplate.Height = 29;
            this.dataGridView_stocks.Size = new System.Drawing.Size(775, 137);
            this.dataGridView_stocks.TabIndex = 54;
            this.dataGridView_stocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stocks_CellClick);
            // 
            // textBox_name2
            // 
            this.textBox_name2.Location = new System.Drawing.Point(141, 74);
            this.textBox_name2.Name = "textBox_name2";
            this.textBox_name2.Size = new System.Drawing.Size(646, 27);
            this.textBox_name2.TabIndex = 49;
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name2.Location = new System.Drawing.Point(11, 78);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(60, 19);
            this.label_name2.TabIndex = 48;
            this.label_name2.Text = "Name2";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(141, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(646, 27);
            this.textBox_name.TabIndex = 47;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(11, 45);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 19);
            this.label_name.TabIndex = 46;
            this.label_name.Text = "Name";
            // 
            // textBox_purchasePrice
            // 
            this.textBox_purchasePrice.Location = new System.Drawing.Point(141, 141);
            this.textBox_purchasePrice.Name = "textBox_purchasePrice";
            this.textBox_purchasePrice.Size = new System.Drawing.Size(168, 27);
            this.textBox_purchasePrice.TabIndex = 45;
            // 
            // label_purchasePrice
            // 
            this.label_purchasePrice.AutoSize = true;
            this.label_purchasePrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_purchasePrice.Location = new System.Drawing.Point(11, 145);
            this.label_purchasePrice.Name = "label_purchasePrice";
            this.label_purchasePrice.Size = new System.Drawing.Size(123, 19);
            this.label_purchasePrice.TabIndex = 44;
            this.label_purchasePrice.Text = "Pruchase Price";
            // 
            // textBox_salePrice
            // 
            this.textBox_salePrice.Location = new System.Drawing.Point(427, 141);
            this.textBox_salePrice.Name = "textBox_salePrice";
            this.textBox_salePrice.Size = new System.Drawing.Size(159, 27);
            this.textBox_salePrice.TabIndex = 66;
            // 
            // label_salePrice
            // 
            this.label_salePrice.AutoSize = true;
            this.label_salePrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_salePrice.Location = new System.Drawing.Point(333, 145);
            this.label_salePrice.Name = "label_salePrice";
            this.label_salePrice.Size = new System.Drawing.Size(85, 19);
            this.label_salePrice.TabIndex = 65;
            this.label_salePrice.Text = "Sale Price";
            // 
            // textBox_vatRate
            // 
            this.textBox_vatRate.Location = new System.Drawing.Point(141, 174);
            this.textBox_vatRate.Name = "textBox_vatRate";
            this.textBox_vatRate.Size = new System.Drawing.Size(168, 27);
            this.textBox_vatRate.TabIndex = 68;
            // 
            // label_vatRate
            // 
            this.label_vatRate.AutoSize = true;
            this.label_vatRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_vatRate.Location = new System.Drawing.Point(14, 178);
            this.label_vatRate.Name = "label_vatRate";
            this.label_vatRate.Size = new System.Drawing.Size(90, 19);
            this.label_vatRate.TabIndex = 67;
            this.label_vatRate.Text = "Vat Rate %";
            // 
            // textBox_discountRate
            // 
            this.textBox_discountRate.Location = new System.Drawing.Point(427, 174);
            this.textBox_discountRate.Name = "textBox_discountRate";
            this.textBox_discountRate.Size = new System.Drawing.Size(159, 27);
            this.textBox_discountRate.TabIndex = 70;
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_discount.Location = new System.Drawing.Point(328, 178);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(93, 19);
            this.label_discount.TabIndex = 69;
            this.label_discount.Text = "Discount %";
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_unit.Location = new System.Drawing.Point(11, 111);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(37, 19);
            this.label_unit.TabIndex = 72;
            this.label_unit.Text = "Unit";
            // 
            // comboBox_stock_UnitID
            // 
            this.comboBox_stock_UnitID.FormattingEnabled = true;
            this.comboBox_stock_UnitID.Location = new System.Drawing.Point(141, 107);
            this.comboBox_stock_UnitID.Name = "comboBox_stock_UnitID";
            this.comboBox_stock_UnitID.Size = new System.Drawing.Size(168, 28);
            this.comboBox_stock_UnitID.TabIndex = 73;
            // 
            // comboBox_currencyID
            // 
            this.comboBox_currencyID.FormattingEnabled = true;
            this.comboBox_currencyID.Location = new System.Drawing.Point(676, 136);
            this.comboBox_currencyID.Name = "comboBox_currencyID";
            this.comboBox_currencyID.Size = new System.Drawing.Size(111, 28);
            this.comboBox_currencyID.TabIndex = 75;
            // 
            // label_currency
            // 
            this.label_currency.AutoSize = true;
            this.label_currency.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_currency.Location = new System.Drawing.Point(592, 140);
            this.label_currency.Name = "label_currency";
            this.label_currency.Size = new System.Drawing.Size(78, 19);
            this.label_currency.TabIndex = 74;
            this.label_currency.Text = "Currency";
            // 
            // comboBox_stockID
            // 
            this.comboBox_stockID.FormattingEnabled = true;
            this.comboBox_stockID.Location = new System.Drawing.Point(141, 7);
            this.comboBox_stockID.Name = "comboBox_stockID";
            this.comboBox_stockID.Size = new System.Drawing.Size(168, 28);
            this.comboBox_stockID.TabIndex = 77;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DarkGray;
            this.button_next.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_next.Location = new System.Drawing.Point(284, 493);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(65, 52);
            this.button_next.TabIndex = 182;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = false;
            // 
            // button_before
            // 
            this.button_before.BackColor = System.Drawing.Color.DarkGray;
            this.button_before.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_before.Location = new System.Drawing.Point(11, 493);
            this.button_before.Name = "button_before";
            this.button_before.Size = new System.Drawing.Size(65, 50);
            this.button_before.TabIndex = 181;
            this.button_before.Text = "<";
            this.button_before.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(218, 493);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(60, 52);
            this.button_update.TabIndex = 180;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(152, 493);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(60, 52);
            this.button_delete.TabIndex = 179;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(81, 493);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(65, 52);
            this.button_ınsert.TabIndex = 178;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click_1);
            // 
            // dataGridView_stocktransferbody
            // 
            this.dataGridView_stocktransferbody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stocktransferbody.Location = new System.Drawing.Point(11, 350);
            this.dataGridView_stocktransferbody.Name = "dataGridView_stocktransferbody";
            this.dataGridView_stocktransferbody.RowHeadersWidth = 51;
            this.dataGridView_stocktransferbody.RowTemplate.Height = 29;
            this.dataGridView_stocktransferbody.Size = new System.Drawing.Size(775, 137);
            this.dataGridView_stocktransferbody.TabIndex = 183;
            this.dataGridView_stocktransferbody.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_stockID
            // 
            this.label_stockID.AutoSize = true;
            this.label_stockID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_stockID.Location = new System.Drawing.Point(11, 11);
            this.label_stockID.Name = "label_stockID";
            this.label_stockID.Size = new System.Drawing.Size(50, 19);
            this.label_stockID.TabIndex = 184;
            this.label_stockID.Text = "Stock";
            // 
            // Form_Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.label_stockID);
            this.Controls.Add(this.dataGridView_stocktransferbody);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_before);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.comboBox_stockID);
            this.Controls.Add(this.comboBox_currencyID);
            this.Controls.Add(this.label_currency);
            this.Controls.Add(this.comboBox_stock_UnitID);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.textBox_discountRate);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.textBox_vatRate);
            this.Controls.Add(this.label_vatRate);
            this.Controls.Add(this.textBox_salePrice);
            this.Controls.Add(this.label_salePrice);
            this.Controls.Add(this.dataGridView_stocks);
            this.Controls.Add(this.textBox_name2);
            this.Controls.Add(this.label_name2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_purchasePrice);
            this.Controls.Add(this.label_purchasePrice);
            this.Name = "Form_Stocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stocktransferbody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView_stocks;
        private TextBox textBox_name2;
        private Label label_name2;
        private TextBox textBox_name;
        private Label label_name;
        private TextBox textBox_purchasePrice;
        private Label label_purchasePrice;
        private TextBox textBox_salePrice;
        private Label label_salePrice;
        private TextBox textBox_vatRate;
        private Label label_vatRate;
        private TextBox textBox_discountRate;
        private Label label_discount;
        private Label label_unit;
        private ComboBox comboBox_stock_UnitID;
        private ComboBox comboBox_currencyID;
        private Label label_currency;
        private ComboBox comboBox_stockID;
        private Button button_next;
        private Button button_before;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private DataGridView dataGridView_stocktransferbody;
        private Label label_stockID;
    }
}