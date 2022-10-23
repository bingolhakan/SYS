namespace SYS.WinFormUI
{
    partial class Form_users
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
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_userId = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_userId = new System.Windows.Forms.Label();
            this.richTextBox_search = new System.Windows.Forms.RichTextBox();
            this.label_employeeID = new System.Windows.Forms.Label();
            this.comboBox_employeeID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(12, 120);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowHeadersWidth = 51;
            this.dataGridView_user.RowTemplate.Height = 29;
            this.dataGridView_user.Size = new System.Drawing.Size(776, 279);
            this.dataGridView_user.TabIndex = 14;
            this.dataGridView_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellClick);
            this.dataGridView_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellContentClick);
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(13, 408);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(103, 38);
            this.button_ınsert.TabIndex = 15;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(122, 408);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 38);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(231, 408);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(103, 38);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(663, 12);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(125, 27);
            this.textBox_password.TabIndex = 13;
            // 
            // textBox_userId
            // 
            this.textBox_userId.Enabled = false;
            this.textBox_userId.Location = new System.Drawing.Point(112, 12);
            this.textBox_userId.Name = "textBox_userId";
            this.textBox_userId.Size = new System.Drawing.Size(125, 27);
            this.textBox_userId.TabIndex = 1;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userName.Location = new System.Drawing.Point(290, 16);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(90, 19);
            this.label_userName.TabIndex = 2;
            this.label_userName.Text = "User Name";
            this.label_userName.Click += new System.EventHandler(this.label_userName_Click);
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(390, 12);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(125, 27);
            this.textBox_userName.TabIndex = 3;
            this.textBox_userName.TextChanged += new System.EventHandler(this.textBox_userName_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(12, 49);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 19);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(112, 45);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(125, 27);
            this.textBox_Name.TabIndex = 5;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_surname.Location = new System.Drawing.Point(290, 49);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(75, 19);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "Surname";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(390, 45);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(125, 27);
            this.textBox_surname.TabIndex = 7;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email.Location = new System.Drawing.Point(563, 49);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(53, 19);
            this.label_email.TabIndex = 8;
            this.label_email.Text = "e-mail";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(663, 45);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(125, 27);
            this.textBox_email.TabIndex = 9;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_password.Location = new System.Drawing.Point(563, 16);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(80, 19);
            this.label_password.TabIndex = 12;
            this.label_password.Text = "Password";
            // 
            // label_userId
            // 
            this.label_userId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_userId.AutoSize = true;
            this.label_userId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userId.Location = new System.Drawing.Point(12, 16);
            this.label_userId.Name = "label_userId";
            this.label_userId.Size = new System.Drawing.Size(65, 19);
            this.label_userId.TabIndex = 0;
            this.label_userId.Text = "User ID";
            this.label_userId.Click += new System.EventHandler(this.label_userId_Click);
            // 
            // richTextBox_search
            // 
            this.richTextBox_search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_search.Location = new System.Drawing.Point(563, 409);
            this.richTextBox_search.Name = "richTextBox_search";
            this.richTextBox_search.Size = new System.Drawing.Size(222, 29);
            this.richTextBox_search.TabIndex = 18;
            this.richTextBox_search.Text = "Search";
            this.richTextBox_search.UseWaitCursor = true;
            // 
            // label_employeeID
            // 
            this.label_employeeID.AutoSize = true;
            this.label_employeeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_employeeID.Location = new System.Drawing.Point(13, 86);
            this.label_employeeID.Name = "label_employeeID";
            this.label_employeeID.Size = new System.Drawing.Size(103, 19);
            this.label_employeeID.TabIndex = 19;
            this.label_employeeID.Text = "Employee ID";
            // 
            // comboBox_employeeID
            // 
            this.comboBox_employeeID.FormattingEnabled = true;
            this.comboBox_employeeID.Location = new System.Drawing.Point(113, 82);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(124, 28);
            this.comboBox_employeeID.TabIndex = 20;
            this.comboBox_employeeID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox_employeeID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_employeeID_MouseClick);
            // 
            // Form_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.label_employeeID);
            this.Controls.Add(this.richTextBox_search);
            this.Controls.Add(this.label_userId);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.dataGridView_user);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.textBox_userId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Form_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView_user;
        private Button button_ınsert;
        private Button button_delete;
        private Button button_update;
        private TextBox textBox_password;
        private TextBox textBox_userId;
        private Label label_userName;
        private TextBox textBox_userName;
        private Label label_name;
        private TextBox textBox_Name;
        private Label label_surname;
        private TextBox textBox_surname;
        private Label label_email;
        private TextBox textBox_email;
        private Label label_password;
        private Label label_userId;
        private RichTextBox richTextBox_search;
        private Label label_employeeID;
        private ComboBox comboBox_employeeID;
    }
}