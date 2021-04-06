using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLThuVien
{
    public partial class inthongtinsach : Form
    {
        SqlConnection cnn;
        public static string maSach;
        public inthongtinsach()
        {
            InitializeComponent();
            connect con = new connect();
            cnn = new SqlConnection(con.cn);
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)

        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport2 r = new CrystalReport2();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_dsSach";
            cnn.Open();
            //   cmd.Parameters.AddWithValue("@ma", maSach);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            r.SetDataSource(dt);
            cnn.Close();
            crystalReportViewer1.ReportSource = r;
            Debug.WriteLine("show: " + dt.Rows.Count);
        }

        private void inthongtinsach_Load(object sender, EventArgs e)
        {
            CrystalReport2 r = new CrystalReport2();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_dsSach";
            cnn.Open();
            //   cmd.Parameters.AddWithValue("@ma", maSach);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            r.SetDataSource(dt);
            cnn.Close();
            crystalReportViewer1.ReportSource = r;
            Debug.WriteLine("show: " + dt.Rows.Count);
        }
    }
}
