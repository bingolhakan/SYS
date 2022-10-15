namespace SYS.WinFormUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sİSTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICITANIMLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_entry = new System.Windows.Forms.Button();
            this.label_userPassword = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_kullaniciSifresi = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImage = global::SYS.WinFormUI.Properties.Resources.Background_Full_HD_Images;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.10697F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.36025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.532774F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİSTEMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sİSTEMToolStripMenuItem
            // 
            this.sİSTEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kULLANICITANIMLARIToolStripMenuItem});
            this.sİSTEMToolStripMenuItem.Name = "sİSTEMToolStripMenuItem";
            this.sİSTEMToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.sİSTEMToolStripMenuItem.Text = "SİSTEM";
            // 
            // kULLANICITANIMLARIToolStripMenuItem
            // 
            this.kULLANICITANIMLARIToolStripMenuItem.Name = "kULLANICITANIMLARIToolStripMenuItem";
            this.kULLANICITANIMLARIToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.kULLANICITANIMLARIToolStripMenuItem.Text = "KULLANICI TANIMLARI";
            this.kULLANICITANIMLARIToolStripMenuItem.Click += new System.EventHandler(this.kULLANICITANIMLARIToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button_entry);
            this.groupBox1.Controls.Add(this.label_userPassword);
            this.groupBox1.Controls.Add(this.label_userName);
            this.groupBox1.Controls.Add(this.textBox_kullaniciSifresi);
            this.groupBox1.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(229, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // button_entry
            // 
            this.button_entry.Location = new System.Drawing.Point(200, 108);
            this.button_entry.Name = "button_entry";
            this.button_entry.Size = new System.Drawing.Size(112, 37);
            this.button_entry.TabIndex = 4;
            this.button_entry.Text = "Giriş";
            this.button_entry.UseVisualStyleBackColor = true;
            // 
            // label_userPassword
            // 
            this.label_userPassword.AutoSize = true;
            this.label_userPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userPassword.Location = new System.Drawing.Point(22, 76);
            this.label_userPassword.Name = "label_userPassword";
            this.label_userPassword.Size = new System.Drawing.Size(44, 19);
            this.label_userPassword.TabIndex = 3;
            this.label_userPassword.Text = "Şifre";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userName.Location = new System.Drawing.Point(22, 44);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(123, 19);
            this.label_userName.TabIndex = 2;
            this.label_userName.Text = "Kullanıcı Adınız";
            // 
            // textBox_kullaniciSifresi
            // 
            this.textBox_kullaniciSifresi.Location = new System.Drawing.Point(151, 72);
            this.textBox_kullaniciSifresi.Name = "textBox_kullaniciSifresi";
            this.textBox_kullaniciSifresi.Size = new System.Drawing.Size(161, 30);
            this.textBox_kullaniciSifresi.TabIndex = 1;
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(151, 40);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(162, 30);
            this.textBox_kullaniciAdi.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NotifyIcon notifyIcon1;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sİSTEMToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox textBox_kullaniciSifresi;
        private TextBox textBox_kullaniciAdi;
        private Label label_userPassword;
        private Label label_userName;
        private Button button_entry;
        private ToolStripMenuItem kULLANICITANIMLARIToolStripMenuItem;
    }
}