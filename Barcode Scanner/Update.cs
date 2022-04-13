using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace Barcode_Scanner
{
    public partial class Update : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ScannerDB;Integrated Security=True");

        public Update()
        {
            
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(txtToolBarcode);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            string name,location;

            txtToolBarcode.Text = e.Barcode;
            conn.Open();

            SqlCommand getName = new SqlCommand("select name from tools where [Tool ID] = '"+txtToolBarcode.Text+"'  ", conn);
            name = getName.ExecuteScalar().ToString();

            SqlCommand getLocation = new SqlCommand("select location from tools where [Tool ID] = '" + txtToolBarcode.Text + "'  ", conn);
            location = getLocation.ExecuteScalar().ToString();

            txtName.Text = name;
            txtLocation.Text = location;
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();


            SqlCommand updateTool = new SqlCommand("update Tools set name = '"+txtName.Text+ "', location = '"+txtLocation.Text+ "' where [Tool ID] = '"+txtToolBarcode.Text+ "' ", conn);
            updateTool.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Tool Updated");
            txtToolBarcode.Clear();
            txtName.Clear();
            txtLocation.Clear();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
