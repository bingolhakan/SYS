namespace SYS.WinFormUI
{
    partial class Form_employees
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
            this.richTextBox_search = new System.Windows.Forms.RichTextBox();
            this.label_employeeID = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.textBox_telephoneNo = new System.Windows.Forms.TextBox();
            this.label_telephoneNo = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_employeeID = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.textBox_district = new System.Windows.Forms.TextBox();
            this.label_district = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.textBox_department = new System.Windows.Forms.TextBox();
            this.label_department = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_search
            // 
            this.richTextBox_search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_search.Location = new System.Drawing.Point(563, 405);
            this.richTextBox_search.Name = "richTextBox_search";
            this.richTextBox_search.Size = new System.Drawing.Size(222, 29);
            this.richTextBox_search.TabIndex = 35;
            this.richTextBox_search.Text = "Search";
            this.richTextBox_search.UseWaitCursor = true;
            // 
            // label_employeeID
            // 
            this.label_employeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_employeeID.AutoSize = true;
            this.label_employeeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_employeeID.Location = new System.Drawing.Point(12, 12);
            this.label_employeeID.Name = "label_employeeID";
            this.label_employeeID.Size = new System.Drawing.Size(103, 19);
            this.label_employeeID.TabIndex = 19;
            this.label_employeeID.Text = "Employee ID";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(231, 404);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(103, 38);
            this.button_update.TabIndex = 34;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(122, 404);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 38);
            this.button_delete.TabIndex = 33;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(13, 404);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(103, 38);
            this.button_ınsert.TabIndex = 32;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click);
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employees.Location = new System.Drawing.Point(12, 144);
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.RowHeadersWidth = 51;
            this.dataGridView_employees.RowTemplate.Height = 29;
            this.dataGridView_employees.Size = new System.Drawing.Size(776, 251);
            this.dataGridView_employees.TabIndex = 31;
            this.dataGridView_employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employees_CellClick);
            // 
            // textBox_telephoneNo
            // 
            this.textBox_telephoneNo.Location = new System.Drawing.Point(121, 111);
            this.textBox_telephoneNo.Name = "textBox_telephoneNo";
            this.textBox_telephoneNo.Size = new System.Drawing.Size(169, 27);
            this.textBox_telephoneNo.TabIndex = 30;
            // 
            // label_telephoneNo
            // 
            this.label_telephoneNo.AutoSize = true;
            this.label_telephoneNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_telephoneNo.Location = new System.Drawing.Point(12, 115);
            this.label_telephoneNo.Name = "label_telephoneNo";
            this.label_telephoneNo.Size = new System.Drawing.Size(107, 19);
            this.label_telephoneNo.TabIndex = 29;
            this.label_telephoneNo.Text = "Telephone No";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(360, 111);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(155, 27);
            this.textBox_email.TabIndex = 28;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email.Location = new System.Drawing.Point(301, 115);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(53, 19);
            this.label_email.TabIndex = 27;
            this.label_email.Text = "e-mail";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(622, 8);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(168, 27);
            this.textBox_surname.TabIndex = 26;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_surname.Location = new System.Drawing.Point(529, 12);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(75, 19);
            this.label_surname.TabIndex = 25;
            this.label_surname.Text = "Surname";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(358, 8);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(157, 27);
            this.textBox_name.TabIndex = 24;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(301, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 19);
            this.label_name.TabIndex = 23;
            this.label_name.Text = "Name";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(122, 41);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(666, 27);
            this.textBox_address.TabIndex = 22;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_address.Location = new System.Drawing.Point(12, 49);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(69, 19);
            this.label_address.TabIndex = 21;
            this.label_address.Text = "Address";
            // 
            // textBox_employeeID
            // 
            this.textBox_employeeID.Enabled = false;
            this.textBox_employeeID.Location = new System.Drawing.Point(122, 8);
            this.textBox_employeeID.Name = "textBox_employeeID";
            this.textBox_employeeID.ReadOnly = true;
            this.textBox_employeeID.Size = new System.Drawing.Size(168, 27);
            this.textBox_employeeID.TabIndex = 20;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(360, 74);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(155, 27);
            this.textBox_city.TabIndex = 39;
            this.textBox_city.TextChanged += new System.EventHandler(this.textBox_city_TextChanged);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_city.Location = new System.Drawing.Point(301, 78);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(38, 19);
            this.label_city.TabIndex = 38;
            this.label_city.Text = "City";
            this.label_city.Click += new System.EventHandler(this.label_city_Click);
            // 
            // textBox_district
            // 
            this.textBox_district.Location = new System.Drawing.Point(121, 74);
            this.textBox_district.Name = "textBox_district";
            this.textBox_district.Size = new System.Drawing.Size(169, 27);
            this.textBox_district.TabIndex = 37;
            // 
            // label_district
            // 
            this.label_district.AutoSize = true;
            this.label_district.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_district.Location = new System.Drawing.Point(13, 78);
            this.label_district.Name = "label_district";
            this.label_district.Size = new System.Drawing.Size(60, 19);
            this.label_district.TabIndex = 36;
            this.label_district.Text = "District";
            // 
            // label_Country
            // 
            this.label_Country.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Country.Location = new System.Drawing.Point(529, 78);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(67, 19);
            this.label_Country.TabIndex = 40;
            this.label_Country.Text = "Country";
            // 
            // comboBox_country
            // 
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Location = new System.Drawing.Point(622, 74);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(166, 28);
            this.comboBox_country.TabIndex = 41;
            this.comboBox_country.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_country_MouseClick);
            // 
            // textBox_department
            // 
            this.textBox_department.Location = new System.Drawing.Point(622, 108);
            this.textBox_department.Name = "textBox_department";
            this.textBox_department.Size = new System.Drawing.Size(166, 27);
            this.textBox_department.TabIndex = 43;
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_department.Location = new System.Drawing.Point(529, 111);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(93, 19);
            this.label_department.TabIndex = 42;
            this.label_department.Text = "Department";
            this.label_department.Click += new System.EventHandler(this.label_department_Click);
            // 
            // Form_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_department);
            this.Controls.Add(this.label_department);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.textBox_district);
            this.Controls.Add(this.label_district);
            this.Controls.Add(this.richTextBox_search);
            this.Controls.Add(this.label_employeeID);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.dataGridView_employees);
            this.Controls.Add(this.textBox_telephoneNo);
            this.Controls.Add(this.label_telephoneNo);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_employeeID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox_search;
        private Label label_employeeID;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private DataGridView dataGridView_employees;
        private TextBox textBox_telephoneNo;
        private Label label_telephoneNo;
        private TextBox textBox_email;
        private Label label_email;
        private TextBox textBox_surname;
        private Label label_surname;
        private TextBox textBox_name;
        private Label label_name;
        private TextBox textBox_address;
        private Label label_address;
        private TextBox textBox_employeeID;
        private TextBox textBox_city;
        private Label label_city;
        private TextBox textBox_district;
        private Label label_district;
        private Label label_Country;
        private ComboBox comboBox_country;
        private TextBox textBox_department;
        private Label label_department;
    }
}