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
    public partial class Print : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ScannerDB;Integrated Security=True");
        string Conn = ("Data Source = (localdb)\\mssqllocaldb;Initial Catalog = ScannerDB; Integrated Security = True");
        public Print()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            //Get File Path Working So File Is At Root of Folder
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"\ToolTime.dat";
            //MessageBox.Show(fileName);
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(Conn);
            //String sql = @"select ClockIn, ClockOut from clockPunches";
            String sql = @"SELECT StudentName, StudentID ,Name , Tools.ToolID, TimeIn, TimeOut
                            FROM InOut
                            INNER JOIN Tools
                            ON InOut.ToolID = Tools.ToolID";

            comm.CommandText = sql;
            comm.Connection.Open();

            SqlDataReader sqlReader = comm.ExecuteReader();
            // Change the Encoding to what you need here (UTF8, Unicode, etc)

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.WriteLine("Name".PadRight(20) + "\t" + "Clock In Time        " + "\t" + "Clock Out Times        " + "\t" + "Total Time(Min)       " + "\t" + "Total Time(Sec)");
                while (sqlReader.Read())
                {
                    //writer.WriteLine(sqlReader["ClockIn"] + "\t" + sqlReader["ClockOut"]);
                    writer.WriteLine(sqlReader["Name"].ToString().PadRight(20) + " \t" + sqlReader["ClockIn"] + "\t" + sqlReader["ClockOut"] + "\t" + sqlReader["TotalTimeDay"] + "\t\t\t" + sqlReader["TotalTimeSeconds"]);
                }
            }

            sqlReader.Close();
            comm.Connection.Close();
        }
    }
}
