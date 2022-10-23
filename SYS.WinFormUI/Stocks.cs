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
using CurrencyManager = SYS.Bussiness.Concrete.CurrencyManager;

namespace SYS.WinFormUI
{
    public partial class Form_Stocks : Form
    {
        StockManager _stockManager = new StockManager();
        Stock_UnitManager _stock_UnitManager = new Stock_UnitManager();
        CurrencyManager _currencyManager = new CurrencyManager();
        public Form_Stocks()
        {
            InitializeComponent();
        }
        private void button_ınsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt etmek istiyormusunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Stock _stock = new Stock();
                _stock.Name = textBox_name.Text;
                _stock.Name2 = textBox_name2.Text;
                _stock.Stock_UnitID = Int32.Parse(comboBox_stock_UnitID.SelectedValue.ToString());
                _stock.PurchasePrice = Int32.Parse(textBox_purchasePrice.Text);
                _stock.SalePrice = Int32.Parse(textBox_salePrice.Text);
                _stock.CurrencyID = Int32.Parse(comboBox_currencyID.SelectedText);
                _stock.VatRate = Double.Parse(textBox_vatRate.Text);
                _stock.DiscountRate = Double.Parse(textBox_discountRate.Text);
                _stockManager.Add(_stock);
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_stocks.DataSource = _stockManager.GetAll();
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_telephoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_telephoneNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_surname_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_address_Click(object sender, EventArgs e)
        {

        }

        private void textBox_employeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_salePrice_Click(object sender, EventArgs e)
        {

        }

        private void textBox_salePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            dataGridView_stocks.DataSource = _stockManager.GetAll();
            dataGridView_stocks.Columns[7].Visible= false;
            dataGridView_stocks.Columns[10].Visible= false;
            dataGridView_stocks.Columns[12].Visible = false;
            dataGridView_stocks.Columns[13].Visible = false;
            comboBox_stock_UnitID.DataSource = _stock_UnitManager.GetAll();
            comboBox_stock_UnitID.DisplayMember = "UnitDescription";
            comboBox_stock_UnitID.ValueMember = "Stock_UnitID";
            comboBox_stock_UnitID.Text = "Seçiniz..";
            comboBox_currencyID.DataSource = _currencyManager.GetAll();
            comboBox_currencyID.DisplayMember = "Description";
            comboBox_currencyID.ValueMember = "CurrencyID";
            comboBox_currencyID.Text = "Seçiniz..";
        }

        private void textBox_discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_stockUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView_stocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_stockID.Text = dataGridView_stocks.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_stocks.CurrentRow.Cells[1].Value.ToString();
            textBox_name2.Text = dataGridView_stocks.CurrentRow.Cells[2].Value.ToString();
            textBox_purchasePrice.Text = dataGridView_stocks.CurrentRow.Cells[3].Value.ToString();
            textBox_salePrice.Text = dataGridView_stocks.CurrentRow.Cells[4].Value.ToString();
            textBox_vatRate.Text = dataGridView_stocks.CurrentRow.Cells[5].Value.ToString();
            textBox_discountRate.Text = dataGridView_stocks.CurrentRow.Cells[6].Value.ToString();
            //comboBox_stock_UnitID.SelectedValue = dataGridView_stocks.Rows[e.RowIndex].Cells[8].Value.ToString();
            //comboBox_currencyID.SelectedValue = dataGridView_stocks.Rows[e.RowIndex].Cells[9].Value.ToString();


        }
    }
}
