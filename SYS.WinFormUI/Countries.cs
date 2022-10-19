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
    public partial class Form_countries : Form
    {
        CountryManager _countryManager = new CountryManager();
        public Form_countries()
        {
            InitializeComponent();
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_countries_Load(object sender, EventArgs e)
        {
            dataGridView_countries.DataSource = _countryManager.GetAll();
            dataGridView_countries.Columns[2].Visible = false;
            dataGridView_countries.Columns[3].Visible = false;
            dataGridView_countries.Columns[4].Visible=false;
        }

        private void dataGridView_countries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_countryID.Text = dataGridView_countries.CurrentRow.Cells[0].Value.ToString();
            textBox_countryName.Text = dataGridView_countries.CurrentRow.Cells[1].Value.ToString();
        }

        private void button_ınsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt etmek istiyormusunuz", "Onay", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                Country _country = new Country();
                _country.CountryName = textBox_countryName.Text;
                _countryManager.Add(_country);
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı", "Bilgi", MessageBoxButtons.OK);
            }
            dataGridView_countries.DataSource= _countryManager.GetAll();    
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinizden eminmisiniz?","Onay",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                Country _country = _countryManager.GetById(Int32.Parse(textBox_countryID.Text));
                _country.IsDelete = true;
                _countryManager.Delete(_country);
                MessageBox.Show("Kayıt başarı ile silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_countries.DataSource = _countryManager.GetAll();

        }
    }
}
