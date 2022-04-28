using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
                writer.WriteLine("Student Name".PadRight(20) + "Student ID".PadRight(20) + "Tool Name".PadRight(20) + "Tool ID".PadRight(20) + "Time In".PadRight(20) + "Time Out".PadLeft(20));
                while (sqlReader.Read())
                {
                    //writer.WriteLine(sqlReader["ClockIn"] + "\t" + sqlReader["ClockOut"]);
                    writer.WriteLine(sqlReader["StudentName"].ToString().PadRight(20) + sqlReader["StudentID"].ToString().PadRight(20)  + sqlReader["Name"].ToString().PadRight(20) + sqlReader["ToolID"].ToString().PadRight(20) + sqlReader["TimeIn"].ToString().PadRight(20) + "\t\t\t" + sqlReader["TimeOut"].ToString().PadLeft(20));
                }
            }

            sqlReader.Close();
            comm.Connection.Close();
        }

        private void btnPrintConsumable_Click(object sender, EventArgs e)
        {
            //Get File Path Working So File Is At Root of Folder
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"\ConsumableTime.dat";
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
                writer.WriteLine("Student Name".PadRight(20) + "Student ID".PadRight(20) + "Tool Name".PadRight(20) + "Tool ID".PadRight(20) + "Time In".PadRight(20) + "Time Out".PadLeft(20));
                while (sqlReader.Read())
                {
                    //writer.WriteLine(sqlReader["ClockIn"] + "\t" + sqlReader["ClockOut"]);
                    writer.WriteLine(sqlReader["StudentName"].ToString().PadRight(20) + sqlReader["StudentID"].ToString().PadRight(20) + sqlReader["Name"].ToString().PadRight(20) + sqlReader["ToolID"].ToString().PadRight(20) + sqlReader["TimeIn"].ToString().PadRight(20) + "\t\t\t" + sqlReader["TimeOut"].ToString().PadLeft(20));
                }
            }

            sqlReader.Close();
            comm.Connection.Close();
        }
    }
}
