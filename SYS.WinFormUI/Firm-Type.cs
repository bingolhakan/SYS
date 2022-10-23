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
    public partial class Form_firmType : Form
    {
        Firm_TypeManager _firm_TypeManager = new Firm_TypeManager();
        SqlConnection _connection = new SqlConnection("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form_firmType()
        {
            InitializeComponent();
        }

        private void Form_firmType_Load(object sender, EventArgs e)
        {
            dataGridView_firmType.DataSource = _firm_TypeManager.GetAll();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult _result=MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.OKCancel);
            if (_result==DialogResult.OK)
            {
                Firm_Type _type = new Firm_Type();
                _type.Description = textBox_description.Text;
                _firm_TypeManager.Add(_type);
                MessageBox.Show("It's saved", "İnformation", MessageBoxButtons.OK);
                dataGridView_firmType.DataSource = _firm_TypeManager.GetAll();
            }

        }

        private void dataGridView_firmType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
