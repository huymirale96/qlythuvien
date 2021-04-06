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

namespace QLThuVien
{
    public partial class insach : Form
    {
        SqlConnection cnn;
        public static string maSach;

        public insach()
        {
            InitializeComponent();
            connect con = new connect();
            cnn = new SqlConnection(con.cn);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rpinsach r = new rpinsach();
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

        }

        private void insach_Load(object sender, EventArgs e)
        {

        }
    }
}
