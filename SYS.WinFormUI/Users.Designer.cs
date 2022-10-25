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
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_employeeID = new System.Windows.Forms.Label();
            this.comboBox_employeeID = new System.Windows.Forms.ComboBox();
            this.comboBox_userID = new System.Windows.Forms.ComboBox();
            this.label_userID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_before = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(8, 121);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowHeadersWidth = 51;
            this.dataGridView_user.RowTemplate.Height = 29;
            this.dataGridView_user.Size = new System.Drawing.Size(776, 279);
            this.dataGridView_user.TabIndex = 14;
            this.dataGridView_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellClick);
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(79, 406);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(65, 52);
            this.button_ınsert.TabIndex = 15;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(150, 406);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(60, 52);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(216, 406);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(60, 52);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(659, 13);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(125, 27);
            this.textBox_password.TabIndex = 13;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userName.Location = new System.Drawing.Point(286, 17);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(90, 19);
            this.label_userName.TabIndex = 2;
            this.label_userName.Text = "User Name";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(386, 13);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(125, 27);
            this.textBox_userName.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(122, 46);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(125, 27);
            this.textBox_Name.TabIndex = 5;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_surname.Location = new System.Drawing.Point(286, 50);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(75, 19);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "Surname";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(386, 46);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(125, 27);
            this.textBox_surname.TabIndex = 7;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email.Location = new System.Drawing.Point(559, 50);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(53, 19);
            this.label_email.TabIndex = 8;
            this.label_email.Text = "e-mail";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(659, 46);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(125, 27);
            this.textBox_email.TabIndex = 9;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_password.Location = new System.Drawing.Point(559, 17);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(80, 19);
            this.label_password.TabIndex = 12;
            this.label_password.Text = "Password";
            // 
            // label_employeeID
            // 
            this.label_employeeID.AutoSize = true;
            this.label_employeeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_employeeID.Location = new System.Drawing.Point(9, 83);
            this.label_employeeID.Name = "label_employeeID";
            this.label_employeeID.Size = new System.Drawing.Size(103, 19);
            this.label_employeeID.TabIndex = 19;
            this.label_employeeID.Text = "Employee ID";
            // 
            // comboBox_employeeID
            // 
            this.comboBox_employeeID.FormattingEnabled = true;
            this.comboBox_employeeID.Location = new System.Drawing.Point(122, 79);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(124, 28);
            this.comboBox_employeeID.TabIndex = 20;
            // 
            // comboBox_userID
            // 
            this.comboBox_userID.FormattingEnabled = true;
            this.comboBox_userID.Location = new System.Drawing.Point(122, 12);
            this.comboBox_userID.Name = "comboBox_userID";
            this.comboBox_userID.Size = new System.Drawing.Size(124, 28);
            this.comboBox_userID.TabIndex = 21;
            this.comboBox_userID.SelectedIndexChanged += new System.EventHandler(this.comboBox_userID_SelectedIndexChanged);
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userID.Location = new System.Drawing.Point(9, 13);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(60, 19);
            this.label_userID.TabIndex = 22;
            this.label_userID.Text = "UserID";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(9, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 19);
            this.label_name.TabIndex = 23;
            this.label_name.Text = "Name";
            // 
            // button_before
            // 
            this.button_before.BackColor = System.Drawing.Color.DarkGray;
            this.button_before.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_before.Location = new System.Drawing.Point(9, 406);
            this.button_before.Name = "button_before";
            this.button_before.Size = new System.Drawing.Size(65, 50);
            this.button_before.TabIndex = 24;
            this.button_before.Text = "<";
            this.button_before.UseVisualStyleBackColor = false;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DarkGray;
            this.button_next.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_next.Location = new System.Drawing.Point(282, 406);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(65, 52);
            this.button_next.TabIndex = 25;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = false;
            // 
            // Form_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_before);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.comboBox_userID);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.label_employeeID);
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
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_userName);
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
        private Label label_userName;
        private TextBox textBox_userName;
        private TextBox textBox_Name;
        private Label label_surname;
        private TextBox textBox_surname;
        private Label label_email;
        private TextBox textBox_email;
        private Label label_password;
        private Label label_employeeID;
        private ComboBox comboBox_employeeID;
        private ComboBox comboBox_userID;
        private Label label_userID;
        private Label label_name;
        private Button button_before;
        private Button button_next;
    }
}