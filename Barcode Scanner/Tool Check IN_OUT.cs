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
            txtQty.Visible = false;
            lblQty.Visible = false;
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
                    string studentInName, studentInId;

                    studentInName = CheckInOut.studentName;
                    studentInId = CheckInOut.studentId;

                    SqlCommand cmd = new SqlCommand("Insert into InOut (StudentId, TimeIn, Amount, ToolID, StudentName) values " +
                                     "('" + studentInId + "','" + DateTime.Now + "' ,'" + txtQty.Text + "' ,'" + txtToolBarcode.Text + "' ,'" + studentInName + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Tool has been clocked in");
                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                    
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
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
                    string studentInName, studentInId;

                    studentInName = CheckInOut.studentName;
                    studentInId = CheckInOut.studentId;

                    SqlCommand cmd = new SqlCommand("Update InOut Set TimeOut = '"+DateTime.Now +"' where StudentId = '"+studentInId+"' and ToolId = '"+txtToolBarcode.Text+"' and TimeOut is null  ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Tool has been clocked out");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();

                }
            }
        }

        private void rbtnTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTool.Checked)
            {
                txtQty.Visible = false;
                lblQty.Visible = false;
                txtQty.Clear();
            }
            else
            {
                txtQty.Visible = true;
                lblQty.Visible = true;
            }
        }
    }
}
