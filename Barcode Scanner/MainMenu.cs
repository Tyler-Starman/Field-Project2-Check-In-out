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

namespace Barcode_Scanner
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scannerDBDataSet2.ProcLiveData' table. You can move, or remove it, as needed.
            this.procLiveDataTableAdapter.Fill(this.scannerDBDataSet2.ProcLiveData);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new AddTools().ShowDialog();
        }

        private void btnChekInOut_Click(object sender, EventArgs e)
        {
            new CheckInOut().ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new Update().ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

          
            new Print().ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.procLiveDataTableAdapter.Fill(this.scannerDBDataSet2.ProcLiveData);

        }
    }
}
