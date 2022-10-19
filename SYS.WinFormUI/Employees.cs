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
    public partial class Form_employees : Form
    {
        EmployeeManager _employeeManager = new EmployeeManager();
        CountryManager _countryManager = new CountryManager();
        public Form_employees()
        {
            InitializeComponent();
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void label_city_Click(object sender, EventArgs e)
        {

        }

        private void textBox_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_employees_Load(object sender, EventArgs e)
        {
            dataGridView_employees.DataSource = _employeeManager.GetAll();
            comboBox_country.DataSource = _countryManager.GetAll();
            comboBox_country.DisplayMember = "CountryName";
            comboBox_country.ValueMember = "CountryID";
        }

        private void button_ınsert_Click(object sender, EventArgs e)
        {
            if ((textBox_name.Text!=null)&&(textBox_surname.Text!=null)&&(textBox_email.Text!=null))
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Information", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Employee _employee = new Employee();
                    _employee.Name = textBox_name.Text;
                    _employee.Surname = textBox_surname.Text;
                    _employee.Address = textBox_address.Text;
                    _employee.District = textBox_district.Text;
                    _employee.City = textBox_city.Text;
                    _employee.CountryID = Int32.Parse(comboBox_country.SelectedValue.ToString());
                    _employee.TelNo = textBox_telephoneNo.Text;
                    _employee.Email = textBox_email.Text;
                    _employee.Department = textBox_department.Text;
                    _employeeManager.Add(_employee);
                    MessageBox.Show("Kayıt işlem başarı ile tamamlandı.","Bilgi",MessageBoxButtons.OK);
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Kayıt işlemi sonlandırıldı", "Bilgi", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi girişi mevcut", "Hata", MessageBoxButtons.OK);
            }
            dataGridView_employees.DataSource = _employeeManager.GetAll();
        }

        private void comboBox_country_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_employeeID.Text = dataGridView_employees.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_employees.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_surname.Text = dataGridView_employees.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_department.Text = dataGridView_employees.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_address.Text = dataGridView_employees.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_district.Text = dataGridView_employees.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_city.Text = dataGridView_employees.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_telephoneNo.Text = dataGridView_employees.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox_email.Text = dataGridView_employees.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBox_country.SelectedValue= dataGridView_employees.Rows[e.RowIndex].Cells[11].Value.ToString();            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_employeeID.Text!=null)
            {
                DialogResult result = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz?", "Bilgi", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    Employee _employee = _employeeManager.GetById(Int32.Parse(textBox_employeeID.Text));
                    _employee.IsDelete = true;
                    _employeeManager.Delete(_employee);
                    MessageBox.Show("Silme işlemi başarı ile tamalandı.", "Bilgi", MessageBoxButtons.OK);
                    textBox_name.Clear();
                    textBox_surname.Clear();
                    textBox_department.Clear();
                    textBox_address.Clear();
                    textBox_district.Clear();
                    textBox_city.Clear();
                    comboBox_country.Text = "Seçiniz..";
                    textBox_telephoneNo.Clear();
                    textBox_email.Clear();
                }
            }
            dataGridView_employees.DataSource = _employeeManager.GetAll();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_employeeID!=null)
            {
                DialogResult result = MessageBox.Show("Güncelleme yapılacaktır. Onaylıyormusunuz?", "Onay", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    Employee _employee = _employeeManager.GetById(Int32.Parse(textBox_employeeID.Text));
                    _employee.Name = textBox_name.Text;
                    _employee.Surname = textBox_surname.Text;
                    _employee.Address = textBox_address.Text;
                    _employee.District = textBox_district.Text;
                    _employee.City = textBox_city.Text;
                    _employee.CountryID = Int32.Parse(comboBox_country.SelectedValue.ToString());
                    _employee.TelNo = textBox_telephoneNo.Text;
                    _employee.Email = textBox_email.Text;
                    _employee.Department = textBox_department.Text;
                    _employeeManager.Update(_employee);
                    MessageBox.Show("Kayıt işlem başarı ile tamamlandı.", "Bilgi", MessageBoxButtons.OK);
                    textBox_employeeID.Clear();
                    textBox_name.Clear();
                    textBox_surname.Clear();
                    textBox_department.Clear();
                    textBox_address.Clear();
                    textBox_district.Clear();
                    textBox_city.Clear();
                    comboBox_country.Text = "Seçiniz..";
                    textBox_telephoneNo.Clear();
                    textBox_email.Clear();
                }
            }
            dataGridView_employees.DataSource = _employeeManager.GetAll();
        }

        private void label_department_Click(object sender, EventArgs e)
        {

        }
    }
}
