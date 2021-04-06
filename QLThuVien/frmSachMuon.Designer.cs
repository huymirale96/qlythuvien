namespace QLThuVien
{
    partial class frmSachMuon
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
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblthongbaosm = new System.Windows.Forms.Label();
            this.btnthoatnv = new System.Windows.Forms.Button();
            this.btnluunv = new System.Windows.Forms.Button();
            this.btnsuanv = new System.Windows.Forms.Button();
            this.btnxoanv = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnthemnv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvsachmuon = new System.Windows.Forms.DataGridView();
            this.dtngaytra = new System.Windows.Forms.GroupBox();
            this.cbomapm = new System.Windows.Forms.ComboBox();
            this.cbomasach = new System.Windows.Forms.ComboBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluongsm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btntoi = new System.Windows.Forms.Button();
            this.btnlui = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsachmuon)).BeginInit();
            this.dtngaytra.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 39);
            this.label9.TabIndex = 28;
            this.label9.Text = "DANH MỤC SÁCH MƯỢN";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox3.Controls.Add(this.lblthongbaosm);
            this.groupBox3.Controls.Add(this.btnthoatnv);
            this.groupBox3.Controls.Add(this.btnluunv);
            this.groupBox3.Controls.Add(this.btnsuanv);
            this.groupBox3.Controls.Add(this.btnxoanv);
            this.groupBox3.Controls.Add(this.btnload);
            this.groupBox3.Controls.Add(this.btnthemnv);
            this.groupBox3.Location = new System.Drawing.Point(16, 331);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(471, 229);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            // 
            // lblthongbaosm
            // 
            this.lblthongbaosm.AutoSize = true;
            this.lblthongbaosm.Location = new System.Drawing.Point(125, 36);
            this.lblthongbaosm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthongbaosm.Name = "lblthongbaosm";
            this.lblthongbaosm.Size = new System.Drawing.Size(0, 17);
            this.lblthongbaosm.TabIndex = 2;
            // 
            // btnthoatnv
            // 
            this.btnthoatnv.Location = new System.Drawing.Point(335, 86);
            this.btnthoatnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoatnv.Name = "btnthoatnv";
            this.btnthoatnv.Size = new System.Drawing.Size(108, 34);
            this.btnthoatnv.TabIndex = 0;
            this.btnthoatnv.Text = "Thoát";
            this.btnthoatnv.UseVisualStyleBackColor = true;
            this.btnthoatnv.Click += new System.EventHandler(this.btnthoatnv_Click);
            // 
            // btnluunv
            // 
            this.btnluunv.Location = new System.Drawing.Point(171, 85);
            this.btnluunv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluunv.Name = "btnluunv";
            this.btnluunv.Size = new System.Drawing.Size(108, 34);
            this.btnluunv.TabIndex = 0;
            this.btnluunv.Text = "Lưu";
            this.btnluunv.UseVisualStyleBackColor = true;
            this.btnluunv.Click += new System.EventHandler(this.btnluunv_Click);
            // 
            // btnsuanv
            // 
            this.btnsuanv.Location = new System.Drawing.Point(328, 165);
            this.btnsuanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsuanv.Name = "btnsuanv";
            this.btnsuanv.Size = new System.Drawing.Size(108, 36);
            this.btnsuanv.TabIndex = 0;
            this.btnsuanv.Text = "Sửa";
            this.btnsuanv.UseVisualStyleBackColor = true;
            this.btnsuanv.Click += new System.EventHandler(this.btnsuanv_Click);
            // 
            // btnxoanv
            // 
            this.btnxoanv.Location = new System.Drawing.Point(169, 165);
            this.btnxoanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoanv.Name = "btnxoanv";
            this.btnxoanv.Size = new System.Drawing.Size(108, 36);
            this.btnxoanv.TabIndex = 0;
            this.btnxoanv.Text = "Xóa";
            this.btnxoanv.UseVisualStyleBackColor = true;
            this.btnxoanv.Click += new System.EventHandler(this.btnxoanv_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(23, 167);
            this.btnload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(108, 34);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "Xuất ";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // btnthemnv
            // 
            this.btnthemnv.Location = new System.Drawing.Point(17, 84);
            this.btnthemnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(108, 34);
            this.btnthemnv.TabIndex = 0;
            this.btnthemnv.Text = "Thêm";
            this.btnthemnv.UseVisualStyleBackColor = true;
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox2.Controls.Add(this.dgvsachmuon);
            this.groupBox2.Location = new System.Drawing.Point(496, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(736, 400);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin Thẻ Thư Viện";
            // 
            // dgvsachmuon
            // 
            this.dgvsachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsachmuon.Location = new System.Drawing.Point(8, 23);
            this.dgvsachmuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvsachmuon.Name = "dgvsachmuon";
            this.dgvsachmuon.RowHeadersWidth = 51;
            this.dgvsachmuon.Size = new System.Drawing.Size(721, 373);
            this.dgvsachmuon.TabIndex = 0;
            // 
            // dtngaytra
            // 
            this.dtngaytra.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.dtngaytra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dtngaytra.Controls.Add(this.cbomapm);
            this.dtngaytra.Controls.Add(this.cbomasach);
            this.dtngaytra.Controls.Add(this.txttinhtrang);
            this.dtngaytra.Controls.Add(this.label3);
            this.dtngaytra.Controls.Add(this.txtsoluongsm);
            this.dtngaytra.Controls.Add(this.label7);
            this.dtngaytra.Controls.Add(this.label2);
            this.dtngaytra.Controls.Add(this.label1);
            this.dtngaytra.Location = new System.Drawing.Point(16, 49);
            this.dtngaytra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtngaytra.Name = "dtngaytra";
            this.dtngaytra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtngaytra.Size = new System.Drawing.Size(471, 274);
            this.dtngaytra.TabIndex = 25;
            this.dtngaytra.TabStop = false;
            this.dtngaytra.Text = "Thông Tin Sách Mượn";
            // 
            // cbomapm
            // 
            this.cbomapm.FormattingEnabled = true;
            this.cbomapm.Location = new System.Drawing.Point(153, 76);
            this.cbomapm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbomapm.Name = "cbomapm";
            this.cbomapm.Size = new System.Drawing.Size(276, 24);
            this.cbomapm.TabIndex = 6;
            // 
            // cbomasach
            // 
            this.cbomasach.FormattingEnabled = true;
            this.cbomasach.Location = new System.Drawing.Point(153, 31);
            this.cbomasach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbomasach.Name = "cbomasach";
            this.cbomasach.Size = new System.Drawing.Size(276, 24);
            this.cbomasach.TabIndex = 6;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(153, 118);
            this.txttinhtrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(184, 22);
            this.txttinhtrang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng SM";
            // 
            // txtsoluongsm
            // 
            this.txtsoluongsm.Location = new System.Drawing.Point(153, 162);
            this.txtsoluongsm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsoluongsm.Name = "txtsoluongsm";
            this.txtsoluongsm.Size = new System.Drawing.Size(184, 22);
            this.txtsoluongsm.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình Trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.groupBox4.Controls.Add(this.btncuoi);
            this.groupBox4.Controls.Add(this.btntoi);
            this.groupBox4.Controls.Add(this.btnlui);
            this.groupBox4.Controls.Add(this.btndau);
            this.groupBox4.Controls.Add(this.txtpage);
            this.groupBox4.Location = new System.Drawing.Point(495, 458);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(744, 100);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Điều Khiền";
            // 
            // btncuoi
            // 
            this.btncuoi.BackgroundImage = global::QLThuVien.Properties.Resources.Actions_green_arrow_right_end_icon;
            this.btncuoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncuoi.Location = new System.Drawing.Point(627, 38);
            this.btncuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(97, 34);
            this.btncuoi.TabIndex = 0;
            this.btncuoi.UseVisualStyleBackColor = true;
            // 
            // btntoi
            // 
            this.btntoi.BackgroundImage = global::QLThuVien.Properties.Resources.next_icon;
            this.btntoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntoi.Location = new System.Drawing.Point(508, 38);
            this.btntoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntoi.Name = "btntoi";
            this.btntoi.Size = new System.Drawing.Size(97, 34);
            this.btntoi.TabIndex = 0;
            this.btntoi.UseVisualStyleBackColor = true;
            // 
            // btnlui
            // 
            this.btnlui.BackgroundImage = global::QLThuVien.Properties.Resources.back_icon;
            this.btnlui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlui.Location = new System.Drawing.Point(127, 38);
            this.btnlui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlui.Name = "btnlui";
            this.btnlui.Size = new System.Drawing.Size(97, 34);
            this.btnlui.TabIndex = 0;
            this.btnlui.UseVisualStyleBackColor = true;
            this.btnlui.Click += new System.EventHandler(this.btnlui_Click);
            // 
            // btndau
            // 
            this.btndau.BackgroundImage = global::QLThuVien.Properties.Resources.Actions_green_arrow_left_end_icon;
            this.btndau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndau.Location = new System.Drawing.Point(8, 36);
            this.btndau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(97, 34);
            this.btndau.TabIndex = 0;
            this.btndau.UseVisualStyleBackColor = true;
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(247, 47);
            this.txtpage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(236, 22);
            this.txtpage.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLThuVien.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1240, 567);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtngaytra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSachMuon";
            this.Text = "FrmDMSachMuon";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.SachMuon_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsachmuon)).EndInit();
            this.dtngaytra.ResumeLayout(false);
            this.dtngaytra.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblthongbaosm;
        private System.Windows.Forms.Button btnthoatnv;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnxoanv;
        private System.Windows.Forms.Button btnsuanv;
        private System.Windows.Forms.Button btnluunv;
        private System.Windows.Forms.Button btnthemnv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvsachmuon;
        private System.Windows.Forms.GroupBox dtngaytra;
        private System.Windows.Forms.ComboBox cbomapm;
        private System.Windows.Forms.ComboBox cbomasach;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluongsm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btntoi;
        private System.Windows.Forms.Button btnlui;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Timer timer1;
    }
}