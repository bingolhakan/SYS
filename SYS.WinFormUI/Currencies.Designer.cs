namespace SYS.WinFormUI
{
    partial class Form_currencies
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
            this.label_currencyID = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ınsert = new System.Windows.Forms.Button();
            this.dataGridView_currency = new System.Windows.Forms.DataGridView();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_currencyId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_currency)).BeginInit();
            this.SuspendLayout();
            // 
            // label_currencyID
            // 
            this.label_currencyID.AutoSize = true;
            this.label_currencyID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_currencyID.Location = new System.Drawing.Point(6, 9);
            this.label_currencyID.Name = "label_currencyID";
            this.label_currencyID.Size = new System.Drawing.Size(100, 19);
            this.label_currencyID.TabIndex = 37;
            this.label_currencyID.Text = "Currency ID";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(224, 199);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(103, 38);
            this.button_update.TabIndex = 35;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(115, 199);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 38);
            this.button_delete.TabIndex = 34;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_ınsert
            // 
            this.button_ınsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ınsert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ınsert.Location = new System.Drawing.Point(6, 199);
            this.button_ınsert.Name = "button_ınsert";
            this.button_ınsert.Size = new System.Drawing.Size(103, 38);
            this.button_ınsert.TabIndex = 33;
            this.button_ınsert.Text = "Insert";
            this.button_ınsert.UseVisualStyleBackColor = false;
            // 
            // dataGridView_currency
            // 
            this.dataGridView_currency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_currency.Location = new System.Drawing.Point(6, 38);
            this.dataGridView_currency.Name = "dataGridView_currency";
            this.dataGridView_currency.RowHeadersWidth = 51;
            this.dataGridView_currency.RowTemplate.Height = 29;
            this.dataGridView_currency.Size = new System.Drawing.Size(538, 155);
            this.dataGridView_currency.TabIndex = 32;
            this.dataGridView_currency.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_currency_CellContentClick);
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(308, 5);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(236, 27);
            this.textBox_description.TabIndex = 31;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(210, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(92, 19);
            this.label_name.TabIndex = 30;
            this.label_name.Text = "Description";
            // 
            // textBox_currencyId
            // 
            this.textBox_currencyId.Enabled = false;
            this.textBox_currencyId.Location = new System.Drawing.Point(106, 5);
            this.textBox_currencyId.Name = "textBox_currencyId";
            this.textBox_currencyId.Size = new System.Drawing.Size(98, 27);
            this.textBox_currencyId.TabIndex = 29;
            // 
            // Form_currencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 245);
            this.Controls.Add(this.label_currencyID);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ınsert);
            this.Controls.Add(this.dataGridView_currency);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_currencyId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_currencies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currencies";
            this.Load += new System.EventHandler(this.Form_currencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_currency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_currencyID;
        private Button button_update;
        private Button button_delete;
        private Button button_ınsert;
        private DataGridView dataGridView_currency;
        private TextBox textBox_description;
        private Label label_name;
        private TextBox textBox_currencyId;
    }
}