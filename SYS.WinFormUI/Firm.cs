using Microsoft.Data.SqlClient;
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
    public partial class Form_firm : Form
    {
        FirmManager _firmManager = new FirmManager();
        Firm_TypeManager _firm_TypeManager = new Firm_TypeManager();
        CountryManager _countryManager = new CountryManager(); 
        SqlConnection _connection = new SqlConnection("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form_firm()
        {
            InitializeComponent();
        }
        private void Form_Firm_Load(object sender, EventArgs e)
        {
            dataGridView_firm.DataSource = _firmManager.GetAll();
            button_delete.Enabled = false;
            button_update.Enabled = false;
        }

        private void dataGridView_firm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_delete.Enabled = true;
            button_update.Enabled = true;
            comboBox_firmID.Text = dataGridView_firm.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_firm.CurrentRow.Cells[1].Value.ToString();
            textBox_address.Text = dataGridView_firm.CurrentRow.Cells[2].Value.ToString();
            textBox_district.Text = dataGridView_firm.CurrentRow.Cells[3].Value.ToString(); 
            textBox_city.Text = dataGridView_firm.CurrentRow.Cells[4].Value.ToString();
            textBox_taxOffice.Text = dataGridView_firm.CurrentRow.Cells[5].Value.ToString();
            textBox_taxNumber.Text = dataGridView_firm.CurrentRow.Cells[6].Value.ToString();
            int id1 = Convert.ToInt32(dataGridView_firm.CurrentRow.Cells[9].Value.ToString());
        }
        private void button_ınsert_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to saved?", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Firm _firm = new Firm();
                _firm.Name = textBox_name.Text;
                _firm.Address = textBox_address.Text;
                _firm.District = textBox_district.Text;
                _firm.City = textBox_city.Text;
                _firm.TaxOffice = textBox_taxOffice.Text;
                _firm.TaxNumber = textBox_taxNumber.Text;
                _firm.CountryID = Int32.Parse(comboBox_countryID.SelectedValue.ToString());
                _firm.Firm_TypeID = Int32.Parse(comboBox_firm_typeID.SelectedValue.ToString());
                _firmManager.Add(_firm);
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Clear();
                textBox_address.Clear();
                textBox_district.Clear();
                textBox_city.Clear();
                comboBox_firm_typeID.Text = "Select..";
                comboBox_countryID.Text = "Select..";
                textBox_taxOffice.Clear();
                textBox_taxNumber.Clear();
            }
            dataGridView_firm.DataSource = _firmManager.GetAll();
        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to deleted?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Firm _firm = _firmManager.GetById(Int32.Parse(comboBox_firmID.Text));
                _firm.Isdelete = true;
                _firmManager.Delete(_firm);
                MessageBox.Show("Silme işlmei başarı ile tamalandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_address.Clear();
                textBox_city.Clear();
                textBox_district.Clear();
                comboBox_firmID.Text="Select..";
                textBox_name.Clear();
                textBox_taxNumber.Clear();
                textBox_taxOffice.Clear();
                comboBox_countryID.Text = "Seçiniz..";
                comboBox_firm_typeID.Text = "Seçiniz..";
            }
            dataGridView_firm.DataSource = _firmManager.GetAll();
        }

        private void button_update_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Güncellemek istiyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Firm _firm = _firmManager.GetById(Int32.Parse(comboBox_firmID.Text));
                _firm.Name = textBox_name.Text;
                _firm.Address = textBox_address.Text;
                _firm.District = textBox_district.Text;
                _firm.City = textBox_city.Text;
                _firm.CountryID = Int32.Parse(comboBox_countryID.SelectedValue.ToString());
                _firm.Firm_TypeID = Int32.Parse(comboBox_firm_typeID.SelectedValue.ToString());
                _firmManager.Update(_firm);
                MessageBox.Show("Silme işlmei başarı ile tamalandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_address.Clear();
                textBox_city.Clear();
                textBox_district.Clear();
                comboBox_firmID.Text="Select..";
                textBox_name.Clear();
                textBox_taxNumber.Clear();
                textBox_taxOffice.Clear();
                comboBox_countryID.Text = "Select..";
                comboBox_firm_typeID.Text = "Select..";
            }
            dataGridView_firm.DataSource = _firmManager.GetAll();
        }
        private void comboBox_firmID_Click(object sender, EventArgs e)
        {
            comboBox_firmID.DataSource = _firmManager.GetAll();
            comboBox_firmID.DisplayMember = "FirmID";
            comboBox_firmID.ValueMember = "FirmID";
            
            SqlCommand _command = new SqlCommand("Select * from Firms where FirmID = @firm",_connection);
            SqlParameter _parameter = new SqlParameter("@firm",comboBox_firmID.Text);
            _command.Parameters.Add(_parameter);
            _connection.Open(); 
            SqlDataReader _datareader = _command.ExecuteReader();
            while (_datareader.Read())
            {

            }
            _connection.Close();
        }

        private void comboBox_firm_typeID_Click(object sender, EventArgs e)
        {
            comboBox_firm_typeID.DataSource = _firm_TypeManager.GetAll();
            comboBox_firm_typeID.DisplayMember = "Description";
            comboBox_firm_typeID.ValueMember = "Firm_TypeID";
        }

        private void comboBox_countryID_Click(object sender, EventArgs e)
        {
            comboBox_countryID.DataSource = _countryManager.GetAll();
            comboBox_countryID.DisplayMember = "CountryName";
            comboBox_countryID.ValueMember = "CountryID";
        }
    }
}
