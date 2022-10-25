using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using SYS.Bussiness.Concrete;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.WinFormUI
{
    public partial class Form_users : Form
    {
        UserManager _userManager = new UserManager();
        EmployeeManager _employeeManager = new EmployeeManager();
        SqlConnection _connection = new SqlConnection("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form_users()
        {
            InitializeComponent();
        }
        private void Form_users_Load(object sender, EventArgs e)
        {
            dataGridView_user.DataSource = _userManager.GetAll();
            dataGridView_user.Columns[6].Visible = false;
            dataGridView_user.Columns[7].Visible = false;
            comboBox_employeeID.DataSource = _employeeManager.GetAll();
            comboBox_employeeID.DisplayMember = "EmployeeID";
            comboBox_employeeID.ValueMember = "EmployeeID";
            SqlCommand _command = new SqlCommand("select UserID from Users",_connection);
            _connection.Open(); 
            SqlDataReader _datareader = _command.ExecuteReader();
            while (_datareader.Read())
            {
                comboBox_userID.Items.Add(_datareader["UserID"]);
            }
            _connection.Close();            
        }

        private void button_ınsert_Click(object sender, EventArgs e)
        {
            if ((textBox_userName.Text!=null)&&(textBox_email.Text!=null)&&(textBox_password.Text!=null))
            {
                DialogResult result=MessageBox.Show("Bilgileri kaydetmek istiyormusunuz?", "Onay", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    Users _users = new Users();
                    _users.UserName = textBox_userName.Text;
                    _users.Password = textBox_password.Text;
                    _users.Name = textBox_Name.Text;
                    _users.Surname = textBox_surname.Text;
                    _users.Email = textBox_email.Text;
                    _users.EmployeeID = Convert.ToInt32(comboBox_employeeID.Text);
                    _userManager.Add(_users);
                    MessageBox.Show("Kayıt işlemi başarı ile gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
                }
            }
            dataGridView_user.DataSource=_userManager.GetAll();
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_userID.Text = dataGridView_user.CurrentRow.Cells[0].Value.ToString();
            textBox_userName.Text = dataGridView_user.CurrentRow.Cells[1].Value.ToString();
            textBox_password.Text = dataGridView_user.CurrentRow.Cells[4].Value.ToString();
            textBox_Name.Text = dataGridView_user.CurrentRow.Cells[2].Value.ToString();
            textBox_surname.Text = dataGridView_user.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView_user.CurrentRow.Cells[5].Value.ToString();
            comboBox_employeeID.SelectedItem = dataGridView_user.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydı silmek istiyormusunuz?", "Onay", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                Users _user = _userManager.GetByID(Int32.Parse(comboBox_userID.Text));
                _user.IsDelete = true;
                _userManager.Delete(_user);
                MessageBox.Show("Silme işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
            }

            dataGridView_user.DataSource = _userManager.GetAll();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bilgileri güncellemek istiyormusunuz?", "Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Users _users = _userManager.GetByID(Int32.Parse(comboBox_userID.Text));
                _users.UserName = textBox_userName.Text;
                _users.Password = textBox_password.Text;
                _users.Name = textBox_Name.Text;
                _users.Surname = textBox_surname.Text;
                _users.Email = textBox_email.Text;
                _users.EmployeeID = Int32.Parse(comboBox_employeeID.SelectedValue.ToString());
                _userManager.Update(_users);
                MessageBox.Show("Güncelleme işlemi başarı ile gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
            }
            dataGridView_user.Refresh();
        }

        private void comboBox_userID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand _command = new SqlCommand("select * from Users where UserID = @userid", _connection);
            SqlParameter _parameter = new SqlParameter("@userid", Int32.Parse(comboBox_userID.Text));
            _command.Parameters.Add(_parameter);
            _connection.Open();
            SqlDataReader _datareader = _command.ExecuteReader();
            while (_datareader.Read())
            {
                textBox_userName.Text =_datareader["UserName"].ToString();
                textBox_password.Text = _datareader["Password"].ToString();
                textBox_Name.Text = _datareader["Name"].ToString();
                textBox_surname.Text = _datareader["Surname"].ToString();
                textBox_email.Text = _datareader["Email"].ToString();
                comboBox_employeeID.Text = _datareader["EmployeeID"].ToString();
            }
            _connection.Close();    
        }
    }
}
