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
    public partial class AddTools : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ScannerDB;Integrated Security=True");

        public AddTools()
        {
            InitializeComponent();
            txtQty.Visible = false;
            lblQty.Visible = false;
            BarcodeScanner barcodeScanner = new BarcodeScanner(txtBarcode);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            txtBarcode.Text = e.Barcode;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbtnTool.Checked) 
            {
                if (txtName.Text == "" || txtLocation.Text == "" || txtBarcode.Text == "") {
                    MessageBox.Show("Please fill all fields");
                }
                else {
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("Insert into tools values ('" + txtBarcode.Text + "','" + txtName.Text + "' ,'" + txtLocation.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Data Submited");
                        txtBarcode.Clear();
                        txtLocation.Clear();
                        txtName.Clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtBarcode.Clear();
                        txtLocation.Clear();
                        txtName.Clear();
                    }
                }
            } 
            else
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Insert into consumable values ('" + txtBarcode.Text + "','" + txtName.Text + "' ,'" + txtQty.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Submited");
                    txtBarcode.Clear();
                    txtQty.Clear();
                    txtName.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtBarcode.Clear();
                    txtQty.Clear();
                    txtName.Clear();
                }
            }


        }

        private void AddTools_Load(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTool.Checked)
            {
                txtQty.Visible = false;
                lblQty.Visible = false;
                txtLocation.Visible = true;
                lblLocation.Visible = true;

                lblName.Text = "Tool Name: ";
                txtQty.Clear();
                txtLocation.Clear();
            }
            else
            {
                txtQty.Visible = true;
                lblQty.Visible = true;

                txtLocation.Visible = false;
                lblLocation.Visible = false;

                lblName.Text = "Consumable Name: ";

                txtQty.Clear();
                txtLocation.Clear();
            }
        }

       
    }
}
