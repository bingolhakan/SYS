namespace SYS.WinFormUI
{
    partial class Form_countries
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
            this.dataGridView_countries = new System.Windows.Forms.DataGridView();
            this.textBox_countryName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_countryID = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_before = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.comboBox_countryID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_countries)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_countries
            // 
            this.dataGridView_countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_countries.Location = new System.Drawing.Point(12, 41);
            this.dataGridView_countries.Name = "dataGridView_countries";
            this.dataGridView_countries.RowHeadersWidth = 51;
            this.dataGridView_countries.RowTemplate.Height = 29;
            this.dataGridView_countries.Size = new System.Drawing.Size(448, 155);
            this.dataGridView_countries.TabIndex = 23;
            this.dataGridView_countries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_countries_CellClick);
            // 
            // textBox_countryName
            // 
            this.textBox_countryName.Location = new System.Drawing.Point(322, 8);
            this.textBox_countryName.Name = "textBox_countryName";
            this.textBox_countryName.Size = new System.Drawing.Size(138, 27);
            this.textBox_countryName.TabIndex = 22;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(202, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(114, 19);
            this.label_name.TabIndex = 21;
            this.label_name.Text = "Country Name";
            // 
            // label_countryID
            // 
            this.label_countryID.AutoSize = true;
            this.label_countryID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_countryID.Location = new System.Drawing.Point(12, 12);
            this.label_countryID.Name = "label_countryID";
            this.label_countryID.Size = new System.Drawing.Size(89, 19);
            this.label_countryID.TabIndex = 28;
            this.label_countryID.Text = "Country ID";
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DarkGray;
            this.button_next.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_next.Location = new System.Drawing.Point(285, 202);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(65, 52);
            this.button_next.TabIndex = 33;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = false;
            // 
            // button_before
            // 
            this.button_before.BackColor = System.Drawing.Color.DarkGray;
            this.button_before.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_before.Location = new System.Drawing.Point(12, 202);
            this.button_before.Name = "button_before";
            this.button_before.Size = new System.Drawing.Size(65, 50);
            this.button_before.TabIndex = 32;
            this.button_before.Text = "<";
            this.button_before.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(219, 202);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(60, 52);
            this.button_update.TabIndex = 31;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(153, 202);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(60, 52);
            this.button_delete.TabIndex = 30;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click_1);
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(82, 202);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(65, 52);
            this.button_ınsert.TabIndex = 29;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click_1);
            // 
            // comboBox_countryID
            // 
            this.comboBox_countryID.FormattingEnabled = true;
            this.comboBox_countryID.Location = new System.Drawing.Point(107, 8);
            this.comboBox_countryID.Name = "comboBox_countryID";
            this.comboBox_countryID.Size = new System.Drawing.Size(79, 28);
            this.comboBox_countryID.TabIndex = 34;
            // 
            // Form_countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 259);
            this.Controls.Add(this.comboBox_countryID);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_before);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.label_countryID);
            this.Controls.Add(this.dataGridView_countries);
            this.Controls.Add(this.textBox_countryName);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_countries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countries";
            this.Load += new System.EventHandler(this.Form_countries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_countries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView_countries;
        private TextBox textBox_countryName;
        private Label label_name;
        private Label label_countryID;
        private Button button_next;
        private Button button_before;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private ComboBox comboBox_countryID;
    }
}