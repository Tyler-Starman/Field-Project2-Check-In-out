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
    public partial class CheckInOut : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ScannerDB;Integrated Security=True");
        public CheckInOut()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(txtStudentID);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
            
        }
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            txtStudentID.Text = e.Barcode;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "" || txtStudentName.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }

            else
            {
                new Tool_Check_IN_OUT().ShowDialog();
            }
        }
    }
}
