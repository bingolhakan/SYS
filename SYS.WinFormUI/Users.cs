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
        public Form_users()
        {
            InitializeComponent();
        }

        private void label_userId_Click(object sender, EventArgs e)
        {

        }

        private void Form_users_Load(object sender, EventArgs e)
        {
            dataGridView_user.DataSource = _userManager.GetAll();
            dataGridView_user.Columns[6].Visible = false;
            dataGridView_user.Columns[7].Visible = false;
            comboBox_employeeID.DataSource = _employeeManager.GetAll();
            comboBox_employeeID.DisplayMember = "Name";
            comboBox_employeeID.ValueMember = "EmployeeID";
        }

        private void label_userName_Click(object sender, EventArgs e)
        {

        }

        private void textBox_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_employeeID_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button_ınsert_Click(object sender, EventArgs e)
        {
            if ((textBox_userName.Text!=null)&&(textBox_email.Text!=null)&&(textBox_password.Text!=null)&&(comboBox_employeeID.SelectedItem!=null))
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
                    _users.EmployeeID = Int32.Parse(comboBox_employeeID.SelectedValue.ToString());
                    _userManager.Add(_users);
                    MessageBox.Show("Kayıt işlemi başarı ile gerçekleştirildi", "Bilgi", MessageBoxButtons.OK);
                }
            }
            dataGridView_user.DataSource=_employeeManager.GetAll();
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_userId.Text = dataGridView_user.CurrentRow.Cells[0].Value.ToString();
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
                Users _user = _userManager.GetByID(Int32.Parse(textBox_userId.Text));
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
                Users _users = _userManager.GetByID(Int32.Parse(textBox_userId.Text));
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
    }
}
