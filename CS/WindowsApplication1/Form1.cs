using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e) {
            gridControl1.ShowPrintPreview();
        }

        private void Form1_Load(object sender,EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }
    }
}