namespace SYS.WinFormUI
{
    partial class Form_firmType
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
            this.label_TypeID = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.dataGridView_firmType = new System.Windows.Forms.DataGridView();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_countryID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firmType)).BeginInit();
            this.SuspendLayout();
            // 
            // label_TypeID
            // 
            this.label_TypeID.AutoSize = true;
            this.label_TypeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TypeID.Location = new System.Drawing.Point(12, 9);
            this.label_TypeID.Name = "label_TypeID";
            this.label_TypeID.Size = new System.Drawing.Size(99, 19);
            this.label_TypeID.TabIndex = 37;
            this.label_TypeID.Text = "Firm TypeID";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Khaki;
            this.button_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(230, 199);
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
            this.button_delete.Location = new System.Drawing.Point(121, 199);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 38);
            this.button_delete.TabIndex = 34;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_Insert
            // 
            this.button_Insert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Insert.Location = new System.Drawing.Point(12, 199);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(103, 38);
            this.button_Insert.TabIndex = 33;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = false;
            // 
            // dataGridView_firmType
            // 
            this.dataGridView_firmType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_firmType.Location = new System.Drawing.Point(12, 38);
            this.dataGridView_firmType.Name = "dataGridView_firmType";
            this.dataGridView_firmType.RowHeadersWidth = 51;
            this.dataGridView_firmType.RowTemplate.Height = 29;
            this.dataGridView_firmType.Size = new System.Drawing.Size(776, 155);
            this.dataGridView_firmType.TabIndex = 32;
            this.dataGridView_firmType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_firmType_CellContentClick);
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(386, 5);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(398, 27);
            this.textBox_description.TabIndex = 31;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_description.Location = new System.Drawing.Point(266, 9);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(92, 19);
            this.label_description.TabIndex = 30;
            this.label_description.Text = "Description";
            // 
            // textBox_countryID
            // 
            this.textBox_countryID.Enabled = false;
            this.textBox_countryID.Location = new System.Drawing.Point(112, 5);
            this.textBox_countryID.Name = "textBox_countryID";
            this.textBox_countryID.Size = new System.Drawing.Size(125, 27);
            this.textBox_countryID.TabIndex = 29;
            // 
            // Form_firmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.label_TypeID);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.dataGridView_firmType);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.textBox_countryID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_firmType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firm_Type";
            this.Load += new System.EventHandler(this.Form_firmType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firmType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_TypeID;
        private Button button_update;
        private Button button_delete;
        private Button button_Insert;
        private DataGridView dataGridView_firmType;
        private TextBox textBox_description;
        private Label label_description;
        private TextBox textBox_countryID;
    }
}