using Microsoft.Data.SqlClient;
using SYS.Bussiness.Concrete;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS.WinFormUI
{
    public partial class Form_stockTransfer : Form
    {
        FirmManager _firmManager = new FirmManager();
        StockManager _stockManager = new StockManager();
        PurchaseOrderManager _purchaseOrderManager = new PurchaseOrderManager();
        SaleOrderManager _saleOrderManager = new SaleOrderManager();
        Stock_TransferBodyManager _BodyManager = new Stock_TransferBodyManager();
        Stock_TransferHeaderManager _headerManager = new Stock_TransferHeaderManager();
        SqlConnection _connection = new SqlConnection("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form_stockTransfer()
        {
            InitializeComponent();
        }
        private void Form_stockTransfer_Load(object sender, EventArgs e)
        {
            SqlCommand _command = new SqlCommand("select * from Stock_TransferHeaders",_connection);
            _connection.Open();
            SqlDataReader _datareader = _command.ExecuteReader();
            while (_datareader.Read())
            {
                comboBox_TransferID.Items.Add(_datareader["TransferHeaderID"]);
            }
            _connection.Close();
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_firmID.Items.Clear();
            comboBox_firmName.Items.Clear();
            comboBox_orderID.Items.Clear();
            comboBox_orderID.Text = "";
            comboBox_stockID.Items.Clear();
            textBox_quantity.Clear();
            if (comboBox_transfertype.Text == "Input")
            {

                SqlCommand _command = new SqlCommand("select [FirmID], [Name] from Firms where Firm_TypeID='1'", _connection);
                _connection.Open();
                SqlDataReader _datareader = _command.ExecuteReader();
                while (_datareader.Read())
                {
                    comboBox_firmID.Items.Add(_datareader["FirmID"]);
                    comboBox_firmName.Items.Add(_datareader["Name"]);
                }
                _connection.Close();
                
            }
            else if(comboBox_transfertype.Text == "Output")
            {
                SqlCommand _command = new SqlCommand("select [FirmID], [Name] from Firms where Firm_TypeID='2'", _connection);
                _connection.Open();
                SqlDataReader _datareader = _command.ExecuteReader();
                while (_datareader.Read())
                {
                    comboBox_firmID.Items.Add(_datareader["FirmID"]);
                    comboBox_firmName.Items.Add(_datareader["Name"]);
                }
                _connection.Close();
            }
        }

        private void button_ınsert_Click(object sender, EventArgs e)
        {
            DialogResult _result=MessageBox.Show("Do you want to save?", "İnformation", MessageBoxButtons.OKCancel);
            if (_result==DialogResult.OK)
            {
                Stock_TransferHeader stock_transferheader=new Stock_TransferHeader();

                stock_transferheader.FirmID = Convert.ToInt32(comboBox_firmID.Text);
                stock_transferheader.Date = Convert.ToDateTime(dateTimePicker_orderDate.Text);
                stock_transferheader.Transfer_Type=comboBox_transfertype.Text;
                stock_transferheader.IsDelete = false;
                _headerManager.Add(stock_transferheader);
                
                MessageBox.Show("Kayıt işlemi tamamlandı","İnformation",MessageBoxButtons.OK);
            }
        }

        private void button_rowadd_Click(object sender, EventArgs e)
        {
            Stock_TransferBody _transferbody = new Stock_TransferBody();

            _transferbody.TransferHeaderID = Convert.ToInt32(comboBox_TransferID.Text);

            if (comboBox_transfertype.Text == "Input")
            {
                _transferbody.PurchaseOrderID = Convert.ToInt32(comboBox_orderID.Text);
                _transferbody.SaleOrderID = 0;
            }
            else if (comboBox_transfertype.Text == "Output")
            {
                _transferbody.PurchaseOrderID =0;
                _transferbody.SaleOrderID = Convert.ToInt32(comboBox_orderID.Text);
                _transferbody.PurchaseOrderID = 0;
            }

            _transferbody.StockID = Convert.ToInt32(comboBox_stockID.Text);

            if (comboBox_transfertype.Text == "Input")
            {
                _transferbody.Input = Convert.ToInt32(textBox_quantity.Text);
                _transferbody.Output = 0;
            }
            else
            {
                _transferbody.Input = 0;
                _transferbody.Output = Convert.ToInt32(textBox_quantity.Text);
            }

            _transferbody.purchaseorders = null;
            _transferbody.saleorders = null;
            _transferbody.stocks = null;
            _transferbody.stock_transferheaders = null;

            _BodyManager.Add(_transferbody);
        }

        private void comboBox_firmID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_transfertype.Text == "Input")
            {
                SqlCommand _command = new SqlCommand("select * from Purchaseorders where FirmID=@Firm", _connection);
                SqlParameter _parameter1 = new SqlParameter("@Firm", comboBox_firmID.Text);
                _command.Parameters.Add(_parameter1);
                _connection.Open();
                SqlDataReader _datareader = _command.ExecuteReader();
                while (_datareader.Read())
                {
                    comboBox_orderID.Items.Add(_datareader["PurchaseOrderID"]);
                }
                _connection.Close();
            }
            else
            {
                SqlCommand _command = new SqlCommand("select * from Saleorders where SaleOrderID=@SO",_connection);
                _connection.Open();
                SqlParameter _parameter1 = new SqlParameter("@SO", comboBox_firmID.Text);
                _command.Parameters.Add(_parameter1);
                SqlDataReader _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    comboBox_orderID.Items.Add(_reader["SaleOrderID"]);
                }
                _connection.Close();
            }
        }

        private void comboBox_TransferID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stock_TransferHeader _transferHeader = _headerManager.GetById(Convert.ToInt32(comboBox_TransferID.Text));
            comboBox_transfertype.Text = _transferHeader.Transfer_Type;
            comboBox_firmID.Text = _transferHeader.FirmID.ToString();

            Firm _firm = _firmManager.GetById(_transferHeader.FirmID);
            comboBox_firmName.Text = _firm.Name;
        }

        private void comboBox_orderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand _command = new SqlCommand("select * from Purchaseorders where PurchaseOrderID=@PO",_connection);
            SqlParameter parameter = new SqlParameter("@PO", comboBox_orderID.Text);
            _command.Parameters.Add(parameter);
            _connection.Open();
            SqlDataReader _datareader = _command.ExecuteReader();
            while (_datareader.Read())
            {
                comboBox_stockID.Items.Add(_datareader["StockID"]);

            }
            _connection.Close();
        }

        private void comboBox_stockID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_transfertype.Text=="Input")
            {
                SqlCommand _command = new SqlCommand("Select * from Purchaseorders where PurchaseOrderID=@PO", _connection);
                SqlParameter _parameter = new SqlParameter("@PO", comboBox_orderID.Text);
                _command.Parameters.Add(_parameter);
                _connection.Open();
                SqlDataReader _datareader = _command.ExecuteReader();
                while (_datareader.Read())
                {
                    textBox_quantity.Text = _datareader["Quantity"].ToString();
                }
                _connection.Close();
            }
            else
            {
                SqlCommand _command = new SqlCommand("Select * from Saleorders where SaleOrderID=@PO", _connection);
                SqlParameter _parameter = new SqlParameter("@PO", comboBox_orderID.Text);
                _command.Parameters.Add(_parameter);
                _connection.Open();
                SqlDataReader _datareader = _command.ExecuteReader();
                while (_datareader.Read())
                {
                    textBox_quantity.Text = _datareader["Quantity"].ToString();
                }
                _connection.Close ();
            }
            
        }

        private void button_ınsert_Click_1(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }
    }
}
