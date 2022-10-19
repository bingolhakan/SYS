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
        public Form_firm()
        {
            InitializeComponent();
        }


        private void label_city_Click(object sender, EventArgs e)
        {

        }

        private void textBox_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Firm_Load(object sender, EventArgs e)
        {
            dataGridView_firm.DataSource = _firmManager.GetAll();
            comboBox_firm_typeID.DataSource = _firm_TypeManager.GetAll();
            comboBox_firm_typeID.DisplayMember = "Description";
            comboBox_firm_typeID.ValueMember = "Firm_TypeID";
            comboBox_countryID.DataSource = _countryManager.GetAll();
            comboBox_countryID.DisplayMember = "CountryName";
            comboBox_countryID.ValueMember = "CountryID";
        }

        private void dataGridView_firm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_firmID.Text = dataGridView_firm.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_firm.CurrentRow.Cells[1].Value.ToString();
            textBox_address.Text = dataGridView_firm.CurrentRow.Cells[2].Value.ToString();
            textBox_district.Text = dataGridView_firm.CurrentRow.Cells[3].Value.ToString(); 
            textBox_city.Text = dataGridView_firm.CurrentRow.Cells[4].Value.ToString();
            textBox_taxOffice.Text = dataGridView_firm.CurrentRow.Cells[5].Value.ToString();
            textBox_taxNumber.Text = dataGridView_firm.CurrentRow.Cells[6].Value.ToString();
            //comboBox_countryID.SelectedItem = dataGridView_firm.CurrentRow.Cells[8].Value.ToString();
            //comboBox_firm_typeID.SelectedItem = dataGridView_firm.CurrentRow.Cells[9].Value.ToString();
        }

        private void button_ınsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt etmek istiyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Clear();
                textBox_address.Clear();
                textBox_district.Clear();
                textBox_city.Clear();
                comboBox_firm_typeID.Text = "Seçiniz..";
                comboBox_countryID.Text = "Seçiniz..";
                textBox_taxOffice.Clear();
                textBox_taxNumber.Clear();
            }   
            dataGridView_firm.DataSource= _firmManager.GetAll();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinizden eminmisiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                Firm _firm = _firmManager.GetById(Int32.Parse(textBox_firmID.Text));
                _firm.Isdelete = true;
                _firmManager.Delete(_firm);
                MessageBox.Show("Silme işlmei başarı ile tamalandı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_address.Clear();
                textBox_city.Clear();
                textBox_district.Clear();
                textBox_firmID.Clear();
                textBox_name.Clear();
                textBox_taxNumber.Clear();
                textBox_taxOffice.Clear();
                comboBox_countryID.Text="Seçiniz..";
                comboBox_firm_typeID.Text="Seçiniz..";
            }
            dataGridView_firm.DataSource= _firmManager.GetAll();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Güncellemek istiyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Firm _firm = _firmManager.GetById(Int32.Parse(textBox_firmID.Text));
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
                textBox_firmID.Clear();
                textBox_name.Clear();
                textBox_taxNumber.Clear();
                textBox_taxOffice.Clear();
                comboBox_countryID.Text = "Seçiniz..";
                comboBox_firm_typeID.Text = "Seçiniz..";
            }
            dataGridView_firm.DataSource = _firmManager.GetAll();
        }
    }
}
