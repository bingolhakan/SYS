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
    public partial class Form_countries : Form
    {
        CountryManager _countryManager = new CountryManager();
        SqlConnection _connection = new SqlConnection("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form_countries()
        {
            InitializeComponent();
        }
        private void Form_countries_Load(object sender, EventArgs e)
        {
            dataGridView_countries.DataSource = _countryManager.GetAll();
            dataGridView_countries.Columns[2].Visible = false;
            dataGridView_countries.Columns[3].Visible = false;
            dataGridView_countries.Columns[4].Visible=false;

            SqlCommand _command = new SqlCommand("select * from Countries where Isdelete='false'", _connection);
            //SqlParameter _parameter = new SqlParameter("@country", comboBox_countryID.Text);
            //_command.Parameters.Add(_parameter);
            _connection.Open();
            SqlDataReader _datareader = _command.ExecuteReader();
            while (_datareader.Read())
            {
                comboBox_countryID.Items.Add(_datareader["CountryID"]);
            }
            _connection.Close();
        }

        private void dataGridView_countries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_countryID.Text = dataGridView_countries.CurrentRow.Cells[0].Value.ToString();
            textBox_countryName.Text = dataGridView_countries.CurrentRow.Cells[1].Value.ToString();
        }
        private void button_ınsert_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save?", "Approval", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Country _country = new Country();
                _country.CountryName = textBox_countryName.Text;
                _countryManager.Add(_country);
                MessageBox.Show("Successfully saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_countries.DataSource = _countryManager.GetAll();
        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete?", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Country _country = _countryManager.GetById(Int32.Parse(comboBox_countryID.Text));
                _country.IsDelete = true;
                _countryManager.Delete(_country);
                MessageBox.Show("The record has been successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_countries.DataSource = _countryManager.GetAll();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to update?", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Country _country = _countryManager.GetById(Int32.Parse(comboBox_countryID.Text));
                _country.CountryName = textBox_countryName.Text;
                _countryManager.Update(_country);
                MessageBox.Show("The record has been successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_countries.DataSource = _countryManager.GetAll();
        }
    }
}
