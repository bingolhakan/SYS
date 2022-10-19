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
            this.richTextBox_search = new System.Windows.Forms.RichTextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.dataGridView_countries = new System.Windows.Forms.DataGridView();
            this.textBox_countryName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_countryID = new System.Windows.Forms.TextBox();
            this.label_countryID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_countries)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_search
            // 
            this.richTextBox_search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_search.Location = new System.Drawing.Point(562, 203);
            this.richTextBox_search.Name = "richTextBox_search";
            this.richTextBox_search.Size = new System.Drawing.Size(222, 29);
            this.richTextBox_search.TabIndex = 27;
            this.richTextBox_search.Text = "Search";
            this.richTextBox_search.UseWaitCursor = true;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(230, 202);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(103, 38);
            this.button_update.TabIndex = 26;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(121, 202);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 38);
            this.button_delete.TabIndex = 25;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(12, 202);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(103, 38);
            this.button_ınsert.TabIndex = 24;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            this.button_ınsert.Click += new System.EventHandler(this.button_ınsert_Click);
            // 
            // dataGridView_countries
            // 
            this.dataGridView_countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_countries.Location = new System.Drawing.Point(12, 41);
            this.dataGridView_countries.Name = "dataGridView_countries";
            this.dataGridView_countries.RowHeadersWidth = 51;
            this.dataGridView_countries.RowTemplate.Height = 29;
            this.dataGridView_countries.Size = new System.Drawing.Size(776, 155);
            this.dataGridView_countries.TabIndex = 23;
            this.dataGridView_countries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_countries_CellClick);
            // 
            // textBox_countryName
            // 
            this.textBox_countryName.Location = new System.Drawing.Point(386, 8);
            this.textBox_countryName.Name = "textBox_countryName";
            this.textBox_countryName.Size = new System.Drawing.Size(398, 27);
            this.textBox_countryName.TabIndex = 22;
            this.textBox_countryName.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(266, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(114, 19);
            this.label_name.TabIndex = 21;
            this.label_name.Text = "Country Name";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // textBox_countryID
            // 
            this.textBox_countryID.Enabled = false;
            this.textBox_countryID.Location = new System.Drawing.Point(112, 8);
            this.textBox_countryID.Name = "textBox_countryID";
            this.textBox_countryID.Size = new System.Drawing.Size(125, 27);
            this.textBox_countryID.TabIndex = 20;
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
            // Form_countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.label_countryID);
            this.Controls.Add(this.richTextBox_search);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.dataGridView_countries);
            this.Controls.Add(this.textBox_countryName);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_countryID);
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

        private RichTextBox richTextBox_search;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private DataGridView dataGridView_countries;
        private TextBox textBox_countryName;
        private Label label_name;
        private TextBox textBox_countryID;
        private Label label_countryID;
    }
}