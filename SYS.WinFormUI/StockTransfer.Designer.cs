namespace SYS.WinFormUI
{
    partial class Form_stockTransfer
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
            this.label_transferID = new System.Windows.Forms.Label();
            this.comboBox_stockID = new System.Windows.Forms.ComboBox();
            this.comboBox_firmID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_orderDate = new System.Windows.Forms.DateTimePicker();
            this.label_transferDate = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_stockID = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_supplierName = new System.Windows.Forms.Label();
            this.comboBox_transfertype = new System.Windows.Forms.ComboBox();
            this.label_transferType = new System.Windows.Forms.Label();
            this.label_orderID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_firmName = new System.Windows.Forms.ComboBox();
            this.comboBox_TransferID = new System.Windows.Forms.ComboBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_before = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.comboBox_orderID = new System.Windows.Forms.ComboBox();
            this.button_rowdelete = new System.Windows.Forms.Button();
            this.button_rowadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_transferID
            // 
            this.label_transferID.AutoSize = true;
            this.label_transferID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_transferID.Location = new System.Drawing.Point(9, 18);
            this.label_transferID.Name = "label_transferID";
            this.label_transferID.Size = new System.Drawing.Size(91, 19);
            this.label_transferID.TabIndex = 154;
            this.label_transferID.Text = "Transfer ID";
            // 
            // comboBox_stockID
            // 
            this.comboBox_stockID.FormattingEnabled = true;
            this.comboBox_stockID.Location = new System.Drawing.Point(334, 42);
            this.comboBox_stockID.Name = "comboBox_stockID";
            this.comboBox_stockID.Size = new System.Drawing.Size(259, 28);
            this.comboBox_stockID.TabIndex = 152;
            this.comboBox_stockID.SelectedIndexChanged += new System.EventHandler(this.comboBox_stockID_SelectedIndexChanged);
            // 
            // comboBox_firmID
            // 
            this.comboBox_firmID.Location = new System.Drawing.Point(135, 45);
            this.comboBox_firmID.Name = "comboBox_firmID";
            this.comboBox_firmID.Size = new System.Drawing.Size(132, 28);
            this.comboBox_firmID.TabIndex = 168;
            this.comboBox_firmID.SelectedIndexChanged += new System.EventHandler(this.comboBox_firmID_SelectedIndexChanged);
            // 
            // dateTimePicker_orderDate
            // 
            this.dateTimePicker_orderDate.Location = new System.Drawing.Point(383, 10);
            this.dateTimePicker_orderDate.Name = "dateTimePicker_orderDate";
            this.dateTimePicker_orderDate.Size = new System.Drawing.Size(139, 27);
            this.dateTimePicker_orderDate.TabIndex = 149;
            // 
            // label_transferDate
            // 
            this.label_transferDate.AutoSize = true;
            this.label_transferDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_transferDate.Location = new System.Drawing.Point(311, 16);
            this.label_transferDate.Name = "label_transferDate";
            this.label_transferDate.Size = new System.Drawing.Size(43, 19);
            this.label_transferDate.TabIndex = 148;
            this.label_transferDate.Text = "Date";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(674, 40);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(83, 27);
            this.textBox_quantity.TabIndex = 137;
            // 
            // label_stockID
            // 
            this.label_stockID.AutoSize = true;
            this.label_stockID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_stockID.Location = new System.Drawing.Point(256, 46);
            this.label_stockID.Name = "label_stockID";
            this.label_stockID.Size = new System.Drawing.Size(72, 19);
            this.label_stockID.TabIndex = 161;
            this.label_stockID.Text = "Stock ID";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_quantity.Location = new System.Drawing.Point(599, 46);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(69, 19);
            this.label_quantity.TabIndex = 157;
            this.label_quantity.Text = "Quantity";
            // 
            // label_supplierName
            // 
            this.label_supplierName.AutoSize = true;
            this.label_supplierName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_supplierName.Location = new System.Drawing.Point(9, 49);
            this.label_supplierName.Name = "label_supplierName";
            this.label_supplierName.Size = new System.Drawing.Size(89, 19);
            this.label_supplierName.TabIndex = 162;
            this.label_supplierName.Text = "Firm Name";
            // 
            // comboBox_transfertype
            // 
            this.comboBox_transfertype.FormattingEnabled = true;
            this.comboBox_transfertype.Items.AddRange(new object[] {
            "Input",
            "Output"});
            this.comboBox_transfertype.Location = new System.Drawing.Point(624, 9);
            this.comboBox_transfertype.Name = "comboBox_transfertype";
            this.comboBox_transfertype.Size = new System.Drawing.Size(151, 28);
            this.comboBox_transfertype.TabIndex = 163;
            this.comboBox_transfertype.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // label_transferType
            // 
            this.label_transferType.AutoSize = true;
            this.label_transferType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_transferType.Location = new System.Drawing.Point(566, 18);
            this.label_transferType.Name = "label_transferType";
            this.label_transferType.Size = new System.Drawing.Size(44, 19);
            this.label_transferType.TabIndex = 164;
            this.label_transferType.Text = "Type";
            // 
            // label_orderID
            // 
            this.label_orderID.AutoSize = true;
            this.label_orderID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_orderID.Location = new System.Drawing.Point(6, 44);
            this.label_orderID.Name = "label_orderID";
            this.label_orderID.Size = new System.Drawing.Size(73, 19);
            this.label_orderID.TabIndex = 166;
            this.label_orderID.Text = "Order ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_rowadd);
            this.groupBox1.Controls.Add(this.button_rowdelete);
            this.groupBox1.Controls.Add(this.label_orderID);
            this.groupBox1.Controls.Add(this.comboBox_orderID);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label_stockID);
            this.groupBox1.Controls.Add(this.comboBox_stockID);
            this.groupBox1.Controls.Add(this.textBox_quantity);
            this.groupBox1.Controls.Add(this.label_quantity);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 226);
            this.groupBox1.TabIndex = 170;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Rows";
            // 
            // comboBox_firmName
            // 
            this.comboBox_firmName.Location = new System.Drawing.Point(275, 45);
            this.comboBox_firmName.Name = "comboBox_firmName";
            this.comboBox_firmName.Size = new System.Drawing.Size(501, 28);
            this.comboBox_firmName.TabIndex = 171;
            // 
            // comboBox_TransferID
            // 
            this.comboBox_TransferID.FormattingEnabled = true;
            this.comboBox_TransferID.Location = new System.Drawing.Point(135, 10);
            this.comboBox_TransferID.Name = "comboBox_TransferID";
            this.comboBox_TransferID.Size = new System.Drawing.Size(132, 28);
            this.comboBox_TransferID.TabIndex = 172;
            this.comboBox_TransferID.SelectedIndexChanged += new System.EventHandler(this.comboBox_TransferID_SelectedIndexChanged);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DarkGray;
            this.button_next.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_next.Location = new System.Drawing.Point(285, 311);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(65, 52);
            this.button_next.TabIndex = 177;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = false;
            // 
            // button_before
            // 
            this.button_before.BackColor = System.Drawing.Color.DarkGray;
            this.button_before.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_before.Location = new System.Drawing.Point(12, 311);
            this.button_before.Name = "button_before";
            this.button_before.Size = new System.Drawing.Size(65, 50);
            this.button_before.TabIndex = 176;
            this.button_before.Text = "<";
            this.button_before.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(219, 311);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(60, 52);
            this.button_update.TabIndex = 175;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(153, 311);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(60, 52);
            this.button_delete.TabIndex = 174;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(82, 311);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(65, 52);
            this.button_ınsert.TabIndex = 173;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click_1);
            // 
            // comboBox_orderID
            // 
            this.comboBox_orderID.FormattingEnabled = true;
            this.comboBox_orderID.Location = new System.Drawing.Point(85, 40);
            this.comboBox_orderID.Name = "comboBox_orderID";
            this.comboBox_orderID.Size = new System.Drawing.Size(165, 28);
            this.comboBox_orderID.TabIndex = 165;
            this.comboBox_orderID.SelectedIndexChanged += new System.EventHandler(this.comboBox_orderID_SelectedIndexChanged);
            // 
            // button_rowdelete
            // 
            this.button_rowdelete.Location = new System.Drawing.Point(374, 82);
            this.button_rowdelete.Name = "button_rowdelete";
            this.button_rowdelete.Size = new System.Drawing.Size(43, 29);
            this.button_rowdelete.TabIndex = 171;
            this.button_rowdelete.Text = "-";
            this.button_rowdelete.UseVisualStyleBackColor = true;
            // 
            // button_rowadd
            // 
            this.button_rowadd.Location = new System.Drawing.Point(325, 82);
            this.button_rowadd.Name = "button_rowadd";
            this.button_rowadd.Size = new System.Drawing.Size(43, 29);
            this.button_rowadd.TabIndex = 172;
            this.button_rowadd.Text = "+";
            this.button_rowadd.UseVisualStyleBackColor = true;
            this.button_rowadd.Click += new System.EventHandler(this.button_rowadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(751, 93);
            this.dataGridView1.TabIndex = 169;
            // 
            // Form_stockTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 374);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_before);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.comboBox_TransferID);
            this.Controls.Add(this.comboBox_firmName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_transferType);
            this.Controls.Add(this.comboBox_transfertype);
            this.Controls.Add(this.label_supplierName);
            this.Controls.Add(this.label_transferID);
            this.Controls.Add(this.comboBox_firmID);
            this.Controls.Add(this.dateTimePicker_orderDate);
            this.Controls.Add(this.label_transferDate);
            this.Name = "Form_stockTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Transfer";
            this.Load += new System.EventHandler(this.Form_stockTransfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_transferID;
        private ComboBox comboBox_stockID;
        private ComboBox comboBox_firmID;
        private DateTimePicker dateTimePicker_orderDate;
        private Label label_transferDate;
        private TextBox textBox_quantity;
        private Label label_stockID;
        private Label label_quantity;
        private Label label_supplierName;
        private ComboBox comboBox_transfertype;
        private Label label_transferType;
        private Label label_orderID;
        private GroupBox groupBox1;
        private ComboBox comboBox_firmName;
        private ComboBox comboBox_TransferID;
        private Button button_next;
        private Button button_before;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private Button button_rowadd;
        private Button button_rowdelete;
        private ComboBox comboBox_orderID;
        private DataGridView dataGridView1;
    }
}