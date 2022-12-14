namespace SYS.WinFormUI
{
    partial class Form_firm
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
            this.comboBox_firm_typeID = new System.Windows.Forms.ComboBox();
            this.label_firm_typeID = new System.Windows.Forms.Label();
            this.comboBox_countryID = new System.Windows.Forms.ComboBox();
            this.label_CounrtyID = new System.Windows.Forms.Label();
            this.textBox_taxNumber = new System.Windows.Forms.TextBox();
            this.label_taxNumber = new System.Windows.Forms.Label();
            this.textBox_taxOffice = new System.Windows.Forms.TextBox();
            this.label_taxOffice = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.dataGridView_firm = new System.Windows.Forms.DataGridView();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_district = new System.Windows.Forms.TextBox();
            this.label_district = new System.Windows.Forms.Label();
            this.comboBox_firmID = new System.Windows.Forms.ComboBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_before = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.label_firmID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firm)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_firm_typeID
            // 
            this.comboBox_firm_typeID.FormattingEnabled = true;
            this.comboBox_firm_typeID.Location = new System.Drawing.Point(410, 8);
            this.comboBox_firm_typeID.Name = "comboBox_firm_typeID";
            this.comboBox_firm_typeID.Size = new System.Drawing.Size(165, 28);
            this.comboBox_firm_typeID.TabIndex = 98;
            this.comboBox_firm_typeID.Click += new System.EventHandler(this.comboBox_firm_typeID_Click);
            // 
            // label_firm_typeID
            // 
            this.label_firm_typeID.AutoSize = true;
            this.label_firm_typeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_firm_typeID.Location = new System.Drawing.Point(326, 12);
            this.label_firm_typeID.Name = "label_firm_typeID";
            this.label_firm_typeID.Size = new System.Drawing.Size(82, 19);
            this.label_firm_typeID.TabIndex = 97;
            this.label_firm_typeID.Text = "Firm Type";
            // 
            // comboBox_countryID
            // 
            this.comboBox_countryID.FormattingEnabled = true;
            this.comboBox_countryID.Location = new System.Drawing.Point(620, 107);
            this.comboBox_countryID.Name = "comboBox_countryID";
            this.comboBox_countryID.Size = new System.Drawing.Size(168, 28);
            this.comboBox_countryID.TabIndex = 96;
            this.comboBox_countryID.Click += new System.EventHandler(this.comboBox_countryID_Click);
            // 
            // label_CounrtyID
            // 
            this.label_CounrtyID.AutoSize = true;
            this.label_CounrtyID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CounrtyID.Location = new System.Drawing.Point(548, 111);
            this.label_CounrtyID.Name = "label_CounrtyID";
            this.label_CounrtyID.Size = new System.Drawing.Size(67, 19);
            this.label_CounrtyID.TabIndex = 95;
            this.label_CounrtyID.Text = "Country";
            // 
            // textBox_taxNumber
            // 
            this.textBox_taxNumber.Location = new System.Drawing.Point(425, 140);
            this.textBox_taxNumber.Name = "textBox_taxNumber";
            this.textBox_taxNumber.Size = new System.Drawing.Size(159, 27);
            this.textBox_taxNumber.TabIndex = 94;
            // 
            // label_taxNumber
            // 
            this.label_taxNumber.AutoSize = true;
            this.label_taxNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_taxNumber.Location = new System.Drawing.Point(326, 144);
            this.label_taxNumber.Name = "label_taxNumber";
            this.label_taxNumber.Size = new System.Drawing.Size(94, 19);
            this.label_taxNumber.TabIndex = 93;
            this.label_taxNumber.Text = "Tax Number";
            // 
            // textBox_taxOffice
            // 
            this.textBox_taxOffice.Location = new System.Drawing.Point(142, 140);
            this.textBox_taxOffice.Name = "textBox_taxOffice";
            this.textBox_taxOffice.Size = new System.Drawing.Size(171, 27);
            this.textBox_taxOffice.TabIndex = 92;
            // 
            // label_taxOffice
            // 
            this.label_taxOffice.AutoSize = true;
            this.label_taxOffice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_taxOffice.Location = new System.Drawing.Point(12, 144);
            this.label_taxOffice.Name = "label_taxOffice";
            this.label_taxOffice.Size = new System.Drawing.Size(81, 19);
            this.label_taxOffice.TabIndex = 91;
            this.label_taxOffice.Text = "Tax Office";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(370, 107);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(159, 27);
            this.textBox_city.TabIndex = 90;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_city.Location = new System.Drawing.Point(326, 111);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(38, 19);
            this.label_city.TabIndex = 89;
            this.label_city.Text = "City";
            // 
            // dataGridView_firm
            // 
            this.dataGridView_firm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_firm.Location = new System.Drawing.Point(13, 173);
            this.dataGridView_firm.Name = "dataGridView_firm";
            this.dataGridView_firm.RowHeadersWidth = 51;
            this.dataGridView_firm.RowTemplate.Height = 29;
            this.dataGridView_firm.Size = new System.Drawing.Size(775, 222);
            this.dataGridView_firm.TabIndex = 85;
            this.dataGridView_firm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_firm_CellClick);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(142, 74);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(646, 27);
            this.textBox_address.TabIndex = 84;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_address.Location = new System.Drawing.Point(12, 78);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(69, 19);
            this.label_address.TabIndex = 83;
            this.label_address.Text = "Address";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(142, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(646, 27);
            this.textBox_name.TabIndex = 82;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(13, 45);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 19);
            this.label_name.TabIndex = 81;
            this.label_name.Text = "Name";
            // 
            // textBox_district
            // 
            this.textBox_district.Location = new System.Drawing.Point(142, 107);
            this.textBox_district.Name = "textBox_district";
            this.textBox_district.Size = new System.Drawing.Size(171, 27);
            this.textBox_district.TabIndex = 80;
            // 
            // label_district
            // 
            this.label_district.AutoSize = true;
            this.label_district.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_district.Location = new System.Drawing.Point(13, 111);
            this.label_district.Name = "label_district";
            this.label_district.Size = new System.Drawing.Size(60, 19);
            this.label_district.TabIndex = 79;
            this.label_district.Text = "District";
            // 
            // comboBox_firmID
            // 
            this.comboBox_firmID.FormattingEnabled = true;
            this.comboBox_firmID.Location = new System.Drawing.Point(142, 7);
            this.comboBox_firmID.Name = "comboBox_firmID";
            this.comboBox_firmID.Size = new System.Drawing.Size(171, 28);
            this.comboBox_firmID.TabIndex = 100;
            this.comboBox_firmID.Click += new System.EventHandler(this.comboBox_firmID_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DarkGray;
            this.button_next.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_next.Location = new System.Drawing.Point(285, 401);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(65, 52);
            this.button_next.TabIndex = 187;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = false;
            // 
            // button_before
            // 
            this.button_before.BackColor = System.Drawing.Color.DarkGray;
            this.button_before.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_before.Location = new System.Drawing.Point(12, 401);
            this.button_before.Name = "button_before";
            this.button_before.Size = new System.Drawing.Size(65, 50);
            this.button_before.TabIndex = 186;
            this.button_before.Text = "<";
            this.button_before.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(219, 401);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(60, 52);
            this.button_update.TabIndex = 185;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click_1);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(153, 401);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(60, 52);
            this.button_delete.TabIndex = 184;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click_1);
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(82, 401);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(65, 52);
            this.button_ınsert.TabIndex = 183;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click_1);
            // 
            // label_firmID
            // 
            this.label_firmID.AutoSize = true;
            this.label_firmID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_firmID.Location = new System.Drawing.Point(13, 12);
            this.label_firmID.Name = "label_firmID";
            this.label_firmID.Size = new System.Drawing.Size(64, 19);
            this.label_firmID.TabIndex = 188;
            this.label_firmID.Text = "Firm ID";
            // 
            // Form_firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label_firmID);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_before);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.comboBox_firmID);
            this.Controls.Add(this.comboBox_firm_typeID);
            this.Controls.Add(this.label_firm_typeID);
            this.Controls.Add(this.comboBox_countryID);
            this.Controls.Add(this.label_CounrtyID);
            this.Controls.Add(this.textBox_taxNumber);
            this.Controls.Add(this.label_taxNumber);
            this.Controls.Add(this.textBox_taxOffice);
            this.Controls.Add(this.label_taxOffice);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.dataGridView_firm);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_district);
            this.Controls.Add(this.label_district);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_firm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firms";
            this.Load += new System.EventHandler(this.Form_Firm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox_firm_typeID;
        private Label label_firm_typeID;
        private ComboBox comboBox_countryID;
        private Label label_CounrtyID;
        private TextBox textBox_taxNumber;
        private Label label_taxNumber;
        private TextBox textBox_taxOffice;
        private Label label_taxOffice;
        private TextBox textBox_city;
        private Label label_city;
        private DataGridView dataGridView_firm;
        private TextBox textBox_address;
        private Label label_address;
        private TextBox textBox_name;
        private Label label_name;
        private TextBox textBox_district;
        private Label label_district;
        private ComboBox comboBox_firmID;
        private Button button_next;
        private Button button_before;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private Label label_firmID;
    }
}