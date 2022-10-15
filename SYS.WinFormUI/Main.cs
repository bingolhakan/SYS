namespace SYS.WinFormUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kULLANICITANIMLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_users form = new Form_users();
            form.Show();
        }
    }
}