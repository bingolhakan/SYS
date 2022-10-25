using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.ApplicationServices;
using SYS.Bussiness.Concrete;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System.Data;
using System.Windows.Forms;

namespace SYS.WinFormUI
{
    public partial class Main : Form
    {
        UserManager _userManager = new UserManager();
        SqlConnection _connection = new SqlConnection("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            groupBox_login.BackColor = Color.Transparent;
            groupBox_login.Location = new Point(850, 400);
            //menuStrip.Enabled = false;
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

        private void sTOCKSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Stocks form = new Form_Stocks();
            form.Show();
        }

        private void fÝRMACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_firm form = new Form_firm();
            form.Show();
        }

        private void pURCHASEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PurchaseOrder form = new Form_PurchaseOrder();
            form.Show();
        }

        private void tRANSFERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_stockTransfer _form = new Form_stockTransfer();
            _form.Show();
        }

        private void fÝRMTYPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_firmType _form = new Form_firmType();
            _form.Show();
        }

        private void button_entry_Click(object sender, EventArgs e)
        {
            if ((textBox_userName.Text != null) && (textBox_password.Text != null))
            {
                SqlCommand _command = new SqlCommand("select * from Users where UserName=@user AND Password=@pass", _connection);
                SqlParameter _parameter1 = new SqlParameter("user", textBox_userName.Text.Trim());
                SqlParameter _parameter2 = new SqlParameter("pass", textBox_password.Text.Trim());
                _command.Parameters.Add(_parameter1);
                _command.Parameters.Add(_parameter2);
                DataTable _datatable = new DataTable();
                SqlDataAdapter _dataadapter = new SqlDataAdapter(_command);
                _dataadapter.Fill(_datatable);
                if (_datatable.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome to SYS", "Welcome", MessageBoxButtons.OK);
                    toolStripStatusLabel_userName.Text = textBox_userName.Text;
                    groupBox_login.Visible = false;
                    menuStrip.Enabled = true;
                    //groupBox_login.Visible = false;
                    textBox_userName.Clear();
                    //textBox_userName.Visible = false;
                    textBox_password.Clear();
                    //textBox_password.Visible = false;
                }
                else
                {
                    MessageBox.Show("The username and pasword incorrect. Please try again", "Error");
                    textBox_userName.Text = "User Name";
                    textBox_password.Text = "Password";

                }
            }
        }
    }
}