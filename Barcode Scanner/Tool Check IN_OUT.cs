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
    public partial class Tool_Check_IN_OUT : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ScannerDB;Integrated Security=True");
        public Tool_Check_IN_OUT()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(txtToolBarcode);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            txtToolBarcode.Text = e.Barcode;
        }

        private void txtToolBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (txtToolBarcode.Text == "" || txtQty.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {
                    conn.Open();

                    //SqlCommand cmd = new SqlCommand("Insert into tools values ('" + txtToolBarcode.Text + "','" + txtQty.Text + "' ,'" + txtLocation.Text + "')", conn);
                    //cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Submited");
                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }
    }
}
