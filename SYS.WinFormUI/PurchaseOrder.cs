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
using CurrencyManager = SYS.Bussiness.Concrete.CurrencyManager;//Soru : Diğerleri için böyle bir tanımlama yapmam gerekmiyordu. Bu hatayı neden aldım?

namespace SYS.WinFormUI
{
    public partial class Form_PurchaseOrder : Form
    {
        PurchaseOrderManager _purchaseOrderManager = new PurchaseOrderManager();
        EmployeeManager _employeeManager = new EmployeeManager();
        StockManager _stockManager = new StockManager();
        FirmManager _firmManager = new FirmManager();
        CurrencyManager _currencyManager = new CurrencyManager();

        public Form_PurchaseOrder()
        {
            InitializeComponent();
        }

        private void dataGridView_firm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_PurchaseOrder_Load(object sender, EventArgs e)
        {
            comboBox_stockID.DataSource = _stockManager.GetAll();
            comboBox_stockID.DisplayMember = "Name";
            comboBox_stockID.ValueMember = "StockID";
            comboBox_stockID.Text = "Seçiniz..";
            comboBox_currencyID.DataSource = _currencyManager.GetAll();
            comboBox_currencyID.DisplayMember = "Description";
            comboBox_currencyID.ValueMember = "CurrencyID";
            comboBox_currencyID.Text = "Seçiniz..";
            comboBox_firmName.DataSource = _firmManager.GetAll();
            comboBox_firmName.DisplayMember = "Name";
            comboBox_firmName.ValueMember = "FirmID";
            comboBox_firmName.Text = "Seçiniz..";
            comboBox_employeeID.DataSource = _employeeManager.GetAll();
            comboBox_employeeID.DisplayMember = "Name";
            comboBox_employeeID.ValueMember = "EmployeeID";
            comboBox_employeeID.Text = "Seçiniz..";
        }

        private void label_quantity_Click(object sender, EventArgs e)
        {

        }

        private void textBox_quantity_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_quantity.Text!="")&&(textBox_unitPrice.Text!=""))
            {
                double a = Convert.ToDouble(textBox_quantity.Text);
                double b = Convert.ToDouble(textBox_unitPrice.Text);
                double result = a * b;
                textBox_subtotal.Text = Convert.ToString(result);
            }

        }

        private void button_ınsert_Click(object sender, EventArgs e)
        {
            PurchaseOrder _purchaseOrder = new PurchaseOrder();
            _purchaseOrder.OrderDate = Convert.ToDateTime(dateTimePicker_orderDate.Text);
            _purchaseOrder.EmployeeID = Int32.Parse(comboBox_employeeID.SelectedValue.ToString());
            _purchaseOrder.FirmID = Int32.Parse(comboBox_firmName.SelectedValue.ToString());
            _purchaseOrder.DeliveryDate = Convert.ToDateTime(dateTimePicker_deliveryDate.Text);
            _purchaseOrder.RevisedDeliveryDate = Convert.ToDateTime(dateTimePicker_revDeliveryDate.Text);
            _purchaseOrder.StockID = Int32.Parse(comboBox_stockID.SelectedValue.ToString());
            _purchaseOrder.Quantity = Int32.Parse(textBox_quantity.Text);
            _purchaseOrder.UnitPrice = Convert.ToDouble(textBox_unitPrice.Text);
            _purchaseOrder.CurrencyID = Int32.Parse(comboBox_currencyID.SelectedValue.ToString()); 

        }

        private void textBox_unitPrice_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_quantity.Text != "") && (textBox_unitPrice.Text != ""))
            {
                double a = Convert.ToDouble(textBox_quantity.Text);
                double b = Convert.ToDouble(textBox_unitPrice.Text);
                double result = a * b;
                textBox_subtotal.Text = Convert.ToString(result);
            }
        }

        private void comboBox_stockID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_stockID_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_stockID_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_stockID_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void dateTimePicker_orderDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
