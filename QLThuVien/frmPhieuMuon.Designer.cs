namespace QLThuVien
{
    partial class frmPhieuMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuMuon));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblthongbaopm = new System.Windows.Forms.Label();
            this.btnin = new System.Windows.Forms.Button();
            this.btntimkiempm = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttimkiemmapm = new System.Windows.Forms.TextBox();
            this.btnxoapm = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthempm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvttpm = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomathe = new System.Windows.Forms.ComboBox();
            this.cbomasach = new System.Windows.Forms.ComboBox();
            this.dtpNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.txtMapm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btntoi = new System.Windows.Forms.Button();
            this.btnlui = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttpm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(558, 36);
            this.label9.TabIndex = 11;
            this.label9.Text = "DANH MỤC DANH SÁCH PHIẾU MƯỢN";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.lblthongbaopm);
            this.groupBox3.Controls.Add(this.btnin);
            this.groupBox3.Controls.Add(this.btntimkiempm);
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Controls.Add(this.txttimkiemmapm);
            this.groupBox3.Controls.Add(this.btnxoapm);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnluu);
            this.groupBox3.Controls.Add(this.btnthempm);
            this.groupBox3.Location = new System.Drawing.Point(19, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(435, 261);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            // 
            // lblthongbaopm
            // 
            this.lblthongbaopm.AutoSize = true;
            this.lblthongbaopm.Location = new System.Drawing.Point(132, 31);
            this.lblthongbaopm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthongbaopm.Name = "lblthongbaopm";
            this.lblthongbaopm.Size = new System.Drawing.Size(0, 17);
            this.lblthongbaopm.TabIndex = 1;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(280, 65);
            this.btnin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(91, 44);
            this.btnin.TabIndex = 0;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btntimkiempm_Click);
            // 
            // btntimkiempm
            // 
            this.btntimkiempm.Location = new System.Drawing.Point(309, 206);
            this.btntimkiempm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimkiempm.Name = "btntimkiempm";
            this.btntimkiempm.Size = new System.Drawing.Size(91, 44);
            this.btntimkiempm.TabIndex = 0;
            this.btntimkiempm.Text = "Tìm Kiếm";
            this.btntimkiempm.UseVisualStyleBackColor = true;
            this.btntimkiempm.Click += new System.EventHandler(this.btntimkiempm_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(280, 138);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(91, 44);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttimkiemmapm
            // 
            this.txttimkiemmapm.Location = new System.Drawing.Point(28, 217);
            this.txttimkiemmapm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiemmapm.Name = "txttimkiemmapm";
            this.txttimkiemmapm.Size = new System.Drawing.Size(243, 22);
            this.txttimkiemmapm.TabIndex = 1;
            this.txttimkiemmapm.Text = "Tìm mã pm";
            // 
            // btnxoapm
            // 
            this.btnxoapm.Location = new System.Drawing.Point(145, 65);
            this.btnxoapm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoapm.Name = "btnxoapm";
            this.btnxoapm.Size = new System.Drawing.Size(91, 44);
            this.btnxoapm.TabIndex = 0;
            this.btnxoapm.Text = "Xóa";
            this.btnxoapm.UseVisualStyleBackColor = true;
            this.btnxoapm.Click += new System.EventHandler(this.btnxoapm_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(145, 138);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 44);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(8, 135);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(91, 44);
            this.btnluu.TabIndex = 0;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthempm
            // 
            this.btnthempm.Location = new System.Drawing.Point(8, 65);
            this.btnthempm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthempm.Name = "btnthempm";
            this.btnthempm.Size = new System.Drawing.Size(91, 44);
            this.btnthempm.TabIndex = 0;
            this.btnthempm.Text = "Thêm";
            this.btnthempm.UseVisualStyleBackColor = true;
            this.btnthempm.Click += new System.EventHandler(this.btnthempm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox2.Controls.Add(this.dgvttpm);
            this.groupBox2.Location = new System.Drawing.Point(469, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(847, 401);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin Nhân Viên";
            // 
            // dgvttpm
            // 
            this.dgvttpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttpm.Location = new System.Drawing.Point(8, 26);
            this.dgvttpm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvttpm.Name = "dgvttpm";
            this.dgvttpm.RowHeadersWidth = 51;
            this.dgvttpm.Size = new System.Drawing.Size(831, 368);
            this.dgvttpm.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dtpNgaytra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbomathe);
            this.groupBox1.Controls.Add(this.cbomasach);
            this.groupBox1.Controls.Add(this.dtpNgaymuon);
            this.groupBox1.Controls.Add(this.txtMapm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(443, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Mượn";
            // 
            // cbomathe
            // 
            this.cbomathe.FormattingEnabled = true;
            this.cbomathe.Location = new System.Drawing.Point(144, 65);
            this.cbomathe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbomathe.Name = "cbomathe";
            this.cbomathe.Size = new System.Drawing.Size(289, 24);
            this.cbomathe.TabIndex = 2;
            // 
            // cbomasach
            // 
            this.cbomasach.FormattingEnabled = true;
            this.cbomasach.Location = new System.Drawing.Point(144, 114);
            this.cbomasach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbomasach.Name = "cbomasach";
            this.cbomasach.Size = new System.Drawing.Size(289, 24);
            this.cbomasach.TabIndex = 2;
            // 
            // dtpNgaymuon
            // 
            this.dtpNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaymuon.Location = new System.Drawing.Point(144, 158);
            this.dtpNgaymuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaymuon.Name = "dtpNgaymuon";
            this.dtpNgaymuon.Size = new System.Drawing.Size(289, 22);
            this.dtpNgaymuon.TabIndex = 2;
            // 
            // txtMapm
            // 
            this.txtMapm.Location = new System.Drawing.Point(144, 27);
            this.txtMapm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMapm.Name = "txtMapm";
            this.txtMapm.Size = new System.Drawing.Size(159, 22);
            this.txtMapm.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PM";
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.Controls.Add(this.btncuoi);
            this.groupBox4.Controls.Add(this.btntoi);
            this.groupBox4.Controls.Add(this.btnlui);
            this.groupBox4.Controls.Add(this.btndau);
            this.groupBox4.Controls.Add(this.txtpage);
            this.groupBox4.Location = new System.Drawing.Point(469, 443);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(852, 100);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Điều Khiền";
            // 
            // btncuoi
            // 
            this.btncuoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncuoi.BackgroundImage")));
            this.btncuoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncuoi.Location = new System.Drawing.Point(719, 34);
            this.btncuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(111, 34);
            this.btncuoi.TabIndex = 0;
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btntoi
            // 
            this.btntoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntoi.BackgroundImage")));
            this.btntoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntoi.Location = new System.Drawing.Point(579, 34);
            this.btntoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntoi.Name = "btntoi";
            this.btntoi.Size = new System.Drawing.Size(111, 34);
            this.btntoi.TabIndex = 0;
            this.btntoi.UseVisualStyleBackColor = true;
            this.btntoi.Click += new System.EventHandler(this.btntoi_Click);
            // 
            // btnlui
            // 
            this.btnlui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlui.BackgroundImage")));
            this.btnlui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlui.Location = new System.Drawing.Point(189, 34);
            this.btnlui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlui.Name = "btnlui";
            this.btnlui.Size = new System.Drawing.Size(111, 34);
            this.btnlui.TabIndex = 0;
            this.btnlui.UseVisualStyleBackColor = true;
            this.btnlui.Click += new System.EventHandler(this.btnlui_Click);
            // 
            // btndau
            // 
            this.btndau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndau.BackgroundImage")));
            this.btndau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndau.Location = new System.Drawing.Point(57, 34);
            this.btndau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(111, 34);
            this.btndau.TabIndex = 0;
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(317, 41);
            this.txtpage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(249, 22);
            this.txtpage.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytra.Location = new System.Drawing.Point(144, 201);
            this.dtpNgaytra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.Size = new System.Drawing.Size(289, 22);
            this.dtpNgaytra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Trả";
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1315, 556);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Mượn";
            this.Load += new System.EventHandler(this.PhieuMuon_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvttpm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblthongbaopm;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoapm;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthempm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvttpm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaymuon;
        private System.Windows.Forms.TextBox txtMapm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntimkiempm;
        private System.Windows.Forms.ComboBox cbomasach;
        private System.Windows.Forms.ComboBox cbomathe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btntoi;
        private System.Windows.Forms.Button btnlui;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.TextBox txttimkiemmapm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpNgaytra;
        private System.Windows.Forms.Label label4;
    }
}