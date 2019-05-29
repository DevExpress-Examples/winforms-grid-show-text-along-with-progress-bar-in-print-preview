using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsBindingSource.DataSource = GetProductsDataTable();
        }

        DataTable GetProductsDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Products";
            table.Columns.Add(new DataColumn("ProductName", typeof(string)));
            table.Columns.Add(new DataColumn("UnitPrice", typeof(double)));
            table.Columns.Add(new DataColumn("UnitsOnOrder", typeof(int)));
            for(int i = 0; i < 20; i++)
            {
                int index = i + 1;
                table.Rows.Add("Product " + index, Math.Round(random.NextDouble() * 1000, 2), random.Next(0, 9) * 10);
            }
            return table;
        }
    }
}