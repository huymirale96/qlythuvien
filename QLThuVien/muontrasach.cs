using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien
{
    public partial class muontrasach : Form
    {
        SqlConnection cnn;
        DataTable vtttv;
        DataRow r1;
        int vt;
        public muontrasach()
        {
            InitializeComponent();
            connect con = new connect();
            cnn = new SqlConnection(con.cn);
            vtttv = new DataTable();
            vtttv = docthethuvien();
        }
        private void muontrasach_Load(object sender, EventArgs e)
        {
            docthethuvien();
            Hienbangpm(txtMa.Text);
            hiensvdautien();
            loaddlsach();

            txtMa.Enabled = false;
            txtMapm.Enabled = false;

        }
        #region hiện thị mã pnt
        private string taomapnt()
        {
            string mapnt;
            Random r = new Random();
            mapnt = "NV" + r.Next(50, 999).ToString();
            return mapnt;
        }
        #endregion
        #region docthethuvien
        public DataTable docthethuvien()
        {

            frmthethuvien f = new frmthethuvien();
            return f.docthethuvien();
        }
        #endregion        
        #region hiện thị mã thẻ
        private string taomathe()
        {
            string mapthe;
            Random r = new Random();
            mapthe = "NV" + r.Next(50, 999).ToString();
            return mapthe;
        }
        #endregion


        #region sinhvien MUON
        #region TTVdautien
        private void hiensvdautien()
        {
            txtpage.Text = vt.ToString();
            vtttv = new DataTable();
            vtttv = docthethuvien();
            DataRow r = vtttv.Rows[vt];
            txtMa.Text = r[0].ToString();
            txtTensv.Text = r[1].ToString();
            cboGioitinh.Text = r[2].ToString();
            dtngaysinh.Text = r[3].ToString();
            txtdiachisv.Text = r[4].ToString();
            txtdt.Text = r[5].ToString();
            dtngaytao.Text = r[6].ToString();
            dtngayhethan.Text = r[7].ToString();
            txtpage.Text = (1 + vt).ToString() + "/" + vtttv.Rows.Count.ToString();
        }
        #endregion
        #region bingding
        private void data_bingding()
        {

        }
        private void huy_bingding()
        {
            if (dtngaysinh.DataBindings != null)
                dtngaysinh.DataBindings.Clear();
            if (txtdt.DataBindings != null)
                txtdt.DataBindings.Clear();
            if (txtMa.DataBindings != null)
                txtMa.DataBindings.Clear();
            if (txtTensv.DataBindings != null)
                txtTensv.DataBindings.Clear();
            if (dtngaytao.DataBindings != null)
                dtngaytao.DataBindings.Clear();
            if (dtngayhethan.DataBindings != null)
                dtngayhethan.DataBindings.Clear();
            if (txtdiachisv.DataBindings != null)
                txtdiachisv.DataBindings.Clear();
            if (cboGioitinh.DataBindings != null)
                cboGioitinh.DataBindings.Clear();
        }
        #endregion
        #region hiện mã pm
        private string taomapm()
        {
            string mapm;
            Random r = new Random();
            mapm = "NV" + r.Next(50, 999).ToString();
            return mapm;
        }
        #endregion        
        #region lam mới dữ liệu

        private void btnthem1_Click(object sender, EventArgs e)
        {
            txtdt.Clear();
            txtMa.Clear();
            txtTensv.Clear();
            txtdiachisv.Clear();
            txtpage.Clear();
            txtMa.Text = taomathe();
        }
        #endregion
        #region thêm vào sinh viên

        #endregion
        #region luu the thu vien 
        private void luuthethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUTHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ma, ten, diachi, dt;
            DateTime ngaytao, ngayhethan, ngaysinh;
            bool gioitinh;
            ma = txtMa.Text;
            ten = txtTensv.Text;
            diachi = txtdiachisv.Text;
            dt = txtdt.Text;
            ngayhethan = DateTime.Parse(dtngayhethan.Value.ToString());
            ngaytao = DateTime.Parse(dtngaytao.Value.ToString());
            ngaysinh = DateTime.Parse(dtngaysinh.Value.ToString());
            if (DateTime.Now.Year - ngaysinh.Year > 85 || DateTime.Now.Year - ngaysinh.Year < 18)
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "sinh viên phải đủ tuổi từ 18-85";
                dtngaysinh.Focus();
                return;
            }
            if (txtTensv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Tên không được để trống";
                txtTensv.Focus();
                return;
            }
            if (txtdiachisv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Địa chỉ không được để trống";
                txtdiachisv.Focus();
                return;
            }
            if (cboGioitinh.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            cmd.Parameters.Add("@MaThe", ma);
            cmd.Parameters.Add("@TenSV", ten);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChiSV", diachi);
            cmd.Parameters.Add("@DienThoai", dt);
            cmd.Parameters.Add("@NgayTao", ngaytao);
            cmd.Parameters.Add("@NgayHetHan", ngayhethan);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "đã tồn tại TheThuViện";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Lưu Thành Công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void btnluu1_Click(object sender, EventArgs e)
        {
            huy_bingding();
            docthethuvien();
            luuthethuvien();
            data_bingding();
        }
        #endregion                        
        #region  sua thethuvien
        private void suathethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ma, ten, diachi, dt;
            DateTime ngaytao, ngayhethan, ngaysinh;
            bool gioitinh;
            ma = txtMa.Text;
            ten = txtTensv.Text;
            diachi = txtdiachisv.Text;
            dt = txtdt.Text;
            ngayhethan = DateTime.Parse(dtngayhethan.Value.ToString());
            ngaytao = DateTime.Parse(dtngaytao.Value.ToString());
            ngaysinh = DateTime.Parse(dtngaysinh.Value.ToString());
            if (cboGioitinh.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            cmd.Parameters.Add("@MaThe", ma);
            cmd.Parameters.Add("@TenSV", ten);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChiSV", diachi);
            cmd.Parameters.Add("@DienThoai", dt);
            cmd.Parameters.Add("@NgayTao", ngaytao);
            cmd.Parameters.Add("@NgayHetHan", ngayhethan);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "đã tồn tại TheThuViện";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Lưu Thành Công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void btnsua1_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suathethuvien();
            data_bingding();
        }
        #endregion
        #region xoanhanvien
        private void XoaNhanVien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string manv;
            manv = txtMa.Text;
            cmd.Parameters.Add("@MaNV", manv);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq1 == DialogResult.Yes)
            {
                try
                {
                    cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction =
                        ParameterDirection.ReturnValue;
                    cnn.Open();
                    cmd.ExecuteNonQuery();

                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Lưu Thành Công";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi kg them duoc vi" + ex.Message);
                }
                finally
                {
                    if (cnn != null)
                        cnn.Close();
                }
            }
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Mã đã tồn tại trong Phiếu nhắc trả";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Xóa Thành Công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void btnxoa1_Click(object sender, EventArgs e)
        {
            huy_bingding();
            XoaNhanVien();
            data_bingding();
        }
        #endregion        
        #region lui
        private void btnlui1_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt--;
                DataRow r = vtttv.Rows[vt];
                txtMa.Text = r[0].ToString();
                txtTensv.Text = r[1].ToString();
                cboGioitinh.Text = r[2].ToString();
                dtngaysinh.Text = r[3].ToString();
                txtdiachisv.Text = r[4].ToString();
                txtdt.Text = r[5].ToString();
                dtngaytao.Text = r[6].ToString();
                dtngayhethan.Text = r[7].ToString();
                txtpage.Text = vt.ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtttv.Rows.Count.ToString();
                btntoi1.Enabled = true;
                Hienbangpm(txtMa.Text);
            }
            else btnlui1.Enabled = false;
        }
        #endregion
        #region toi
        private void btntoi1_Click(object sender, EventArgs e)
        {
            if (vt < vtttv.Rows.Count - 1)
            {
                vt++;
                DataRow r = vtttv.Rows[vt];
                txtMa.Text = r[0].ToString();
                txtTensv.Text = r[1].ToString();
                cboGioitinh.Text = r[2].ToString();
                dtngaysinh.Text = r[3].ToString();
                txtdiachisv.Text = r[4].ToString();
                txtdt.Text = r[5].ToString();
                dtngaytao.Text = r[6].ToString();
                dtngayhethan.Text = r[7].ToString();
                txtpage.Text = vt.ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtttv.Rows.Count.ToString();
                btnlui1.Enabled = true;
                Hienbangpm(txtMa.Text);
            }
            else btntoi1.Enabled = false;
        }
        #endregion
        #region cuoi
        private void btncuoi1_Click(object sender, EventArgs e)
        {
            if (vt < vtttv.Rows.Count - 1)
            {
                vt = vtttv.Rows.Count - 1;
                DataRow r = vtttv.Rows[vt];
                txtMa.Text = r[0].ToString();
                txtTensv.Text = r[1].ToString();
                cboGioitinh.Text = r[2].ToString();
                dtngaysinh.Text = r[3].ToString();
                txtdiachisv.Text = r[4].ToString();
                txtdt.Text = r[5].ToString();
                dtngaytao.Text = r[6].ToString();
                dtngayhethan.Text = r[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtttv.Rows.Count.ToString();
                btndau1.Enabled = true;
                Hienbangpm(txtMa.Text);
            }
            else btncuoi1.Enabled = false;
        }
        #endregion
        #region dau
        private void btndau1_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt = 0;
                DataRow r = vtttv.Rows[vt];
                txtMa.Text = r[0].ToString();
                txtTensv.Text = r[1].ToString();
                cboGioitinh.Text = r[2].ToString();
                dtngaysinh.Text = r[3].ToString();
                txtdiachisv.Text = r[4].ToString();
                txtdt.Text = r[5].ToString();
                dtngaytao.Text = r[6].ToString();
                dtngayhethan.Text = r[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtttv.Rows.Count.ToString();
                btncuoi1.Enabled = true;
                Hienbangpm(txtMa.Text);
            }
            else btndau1.Enabled = false;
        }
        #endregion
        #endregion


        #region load SACH
        private DataTable docsach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADSACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable sach = new DataTable();
            cnn.Open();
            sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return sach;
        }
        private void loaddlsach()
        {
            cbomasach.DataSource = docsach();
            cbomasach.ValueMember = "MaSach";
            cbomasach.DisplayMember = "TenSach";
        }
        #endregion


        #region XU LY PHIEU MUON
        #region thempm
        private void btnthempm_Click(object sender, EventArgs e)
        {
            txtMapm.Clear();
            txtMapm.Text = taomapm();
        }
        #endregion
        #region luuphieumuon
        private void luuphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_Luuphieumuonsinhvien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, mathe, masach;
            DateTime ngaymuon, ngaytra;
            mapm = txtMapm.Text;
            masach = cbomasach.SelectedValue.ToString();
            mathe = txtMa.Text;
            ngaymuon = DateTime.Parse(dtpNgaymuon.Value.ToString());
            ngaytra = DateTime.Parse(dtpNgaytra.Value.ToString());
            cmd.Parameters.AddWithValue("@MaPM", mapm);
            cmd.Parameters.AddWithValue("@MaSach", masach);
            cmd.Parameters.AddWithValue("@MaThe", mathe);
            cmd.Parameters.AddWithValue("@NgayMuon", ngaymuon);
            cmd.Parameters.AddWithValue("@NgayTra", ngaytra);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Đã tồn tại phiếu mượn";
                    return;
                }
                else if (kq == 2)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Không tồn tại sách ";
                    return;
                }
                else if (kq == 3)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else if (kq == 4)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Sinh viên mượn không quá 3 Quyển";
                    return;
                }
                else
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Luu Thành Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void btnluupm_Click(object sender, EventArgs e)
        {
            luuphieumuon();
            Hienbangpm(txtMa.Text);
            docthethuvien();
        }
        #endregion
        #region docpm
        private DataTable docphieumuon(string mathe)
        {
            DataTable pmsv = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_Docphieumuonsinhvien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            //masv = txtmasv.Text;
            cmd.Parameters.AddWithValue("@mathe", mathe);
            try
            {
                cnn.Open();
                pmsv.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi khong doc duoc phieu muon", e.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
            return pmsv;
        }
        private void Hienbangpm(string mathe)
        {
            huybingdingketqua();
            dgvds1.DataSource = docphieumuon(mathe);
            bingdingketqua();
        }
        #endregion
        #region bingdingkq
        private void bingdingketqua()
        {
            cbomasach.DataBindings.Add("SelectedValue", dgvds1.DataSource, "MaSach");
            txtMapm.DataBindings.Add("Text", dgvds1.DataSource, "MaPM");
        }
        private void huybingdingketqua()
        {
            if (cbomasach.DataBindings != null)
                cbomasach.DataBindings.Clear();
            if (txtMapm.DataBindings != null)
                txtMapm.DataBindings.Clear();
        }
        #endregion
        #region  sua phieu muon
        private void suaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUAPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, mathe, masach;
            DateTime ngaymuon, ngaytra;
            mapm = txtMapm.Text;
            masach = cbomasach.SelectedValue.ToString();
            mathe = txtMa.Text;
            ngaymuon = DateTime.Parse(dtpNgaymuon.Value.ToString());
            ngaytra = DateTime.Parse(dtpNgaytra.Value.ToString());
            cmd.Parameters.Add("@MaPM", mapm);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaThe", mathe);
            cmd.Parameters.Add("@NgayMuon", ngaymuon);
            cmd.Parameters.AddWithValue("@NgayTra", ngaytra);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "không tồn tại phiếu mượn";
                    return;
                }
                else if (kq == 1)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Không tồn tại sách ";
                    return;
                }
                else if (kq == 1)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Sửa Thành Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void btnsuapm_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suaphieumuon();
            Hienbangpm(txtMa.Text);
            docthethuvien();
            data_bingding();
        }
        #endregion
        #region xoa phieumuon
        private void xoaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_Xoaphieumuonsinhvien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm;
            mapm = txtMapm.Text;
            cmd.Parameters.Add("@MaPM", mapm);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Đã tồn tại PM trong sách mượn";
                    return;
                }
                else
                {
                    lbltbpm.ForeColor = Color.Red;
                    lbltbpm.Text = "Xóa Thành Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void btnxoapm_Click(object sender, EventArgs e)
        {
            huybingdingketqua();
            xoaphieumuon();
            Hienbangpm(txtMa.Text);
        }
        #endregion
        #endregion




        private void btnin1_Click(object sender, EventArgs e)
        {
            inthongtinsach f = new inthongtinsach();
            f.ShowDialog();
        }
        #region bat loi ten va dien thoai
        private void txtTensv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 45 && e.KeyChar < 57)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập số";
            }
        }


        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }
        #endregion


    }
}
