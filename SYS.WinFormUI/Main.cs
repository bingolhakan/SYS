using SYS.Bussiness.Concrete;
using SYS.Entities.Concrete;

namespace SYS.WinFormUI
{
    public partial class Main : Form
    {
        UserManager _userManager = new UserManager(); 
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            groupBox_login.BackColor = Color.Transparent;
            //textBox_userName.BackColor = Color.Transparent;
            //textBox_password.BackColor = Color.Transparent;
            groupBox_login.Location = new Point(850,400);
         }

        private void eMPLOYEEACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_employees form = new Form_employees();
            form.Show();
        }

        private void uSERACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_users form = new Form_users();
            form.Show();
        }

        private void cOUNTRIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_countries form = new Form_countries();
            form.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cURRENCIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_currencies form = new Form_currencies();
            form.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox_userName.Text;
            string password = textBox_password.Text;    
            if ((textBox_userName!=null)&&(textBox_password!=null))
            {

                    toolStripStatusLabel_userName.Text=textBox_userName.Text;
            }
        }

        private void sTOCKSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sTOCKSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Stocks form = new Form_Stocks();
            form.Show();
        }

        private void f›RMACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_firm form = new Form_firm();
            form.Show();
        }
    }
}