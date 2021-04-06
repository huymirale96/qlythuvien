namespace QLThuVien
{
    partial class thongtinsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongtinsach));
            this.dgvthongtin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnin = new System.Windows.Forms.Button();
            this.btnthongtin = new System.Windows.Forms.Button();
            this.chsachkbd = new System.Windows.Forms.CheckBox();
            this.chsachbandc = new System.Windows.Forms.CheckBox();
            this.chsachhu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvthongtin
            // 
            this.dgvthongtin.AllowUserToAddRows = false;
            this.dgvthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtin.Location = new System.Drawing.Point(8, 23);
            this.dgvthongtin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvthongtin.Name = "dgvthongtin";
            this.dgvthongtin.RowHeadersWidth = 51;
            this.dgvthongtin.Size = new System.Drawing.Size(915, 274);
            this.dgvthongtin.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnin);
            this.groupBox1.Controls.Add(this.btnthongtin);
            this.groupBox1.Controls.Add(this.chsachkbd);
            this.groupBox1.Controls.Add(this.chsachbandc);
            this.groupBox1.Controls.Add(this.chsachhu);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(-1, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(931, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử Lý Thông Tin";
            // 
            // btnin
            // 
            this.btnin.ForeColor = System.Drawing.Color.Black;
            this.btnin.Location = new System.Drawing.Point(776, 85);
            this.btnin.Margin = new System.Windows.Forms.Padding(4);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(100, 28);
            this.btnin.TabIndex = 1;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthongtin
            // 
            this.btnthongtin.ForeColor = System.Drawing.Color.Black;
            this.btnthongtin.Location = new System.Drawing.Point(776, 33);
            this.btnthongtin.Margin = new System.Windows.Forms.Padding(4);
            this.btnthongtin.Name = "btnthongtin";
            this.btnthongtin.Size = new System.Drawing.Size(100, 28);
            this.btnthongtin.TabIndex = 1;
            this.btnthongtin.Text = "Thông Tin";
            this.btnthongtin.UseVisualStyleBackColor = true;
            this.btnthongtin.Click += new System.EventHandler(this.button1_Click);
            // 
            // chsachkbd
            // 
            this.chsachkbd.AutoSize = true;
            this.chsachkbd.BackColor = System.Drawing.Color.Transparent;
            this.chsachkbd.ForeColor = System.Drawing.Color.Black;
            this.chsachkbd.Location = new System.Drawing.Point(503, 41);
            this.chsachkbd.Margin = new System.Windows.Forms.Padding(4);
            this.chsachkbd.Name = "chsachkbd";
            this.chsachkbd.Size = new System.Drawing.Size(198, 21);
            this.chsachkbd.TabIndex = 0;
            this.chsachkbd.Text = "Số sách không được mượn";
            this.chsachkbd.UseVisualStyleBackColor = false;
            // 
            // chsachbandc
            // 
            this.chsachbandc.AutoSize = true;
            this.chsachbandc.BackColor = System.Drawing.Color.Transparent;
            this.chsachbandc.ForeColor = System.Drawing.Color.Black;
            this.chsachbandc.Location = new System.Drawing.Point(237, 41);
            this.chsachbandc.Margin = new System.Windows.Forms.Padding(4);
            this.chsachbandc.Name = "chsachbandc";
            this.chsachbandc.Size = new System.Drawing.Size(226, 21);
            this.chsachbandc.TabIndex = 0;
            this.chsachbandc.Text = "Số sách được mượn nhiều nhất";
            this.chsachbandc.UseVisualStyleBackColor = false;
            // 
            // chsachhu
            // 
            this.chsachhu.AutoSize = true;
            this.chsachhu.BackColor = System.Drawing.Color.Transparent;
            this.chsachhu.ForeColor = System.Drawing.Color.Black;
            this.chsachhu.Location = new System.Drawing.Point(32, 41);
            this.chsachhu.Margin = new System.Windows.Forms.Padding(4);
            this.chsachhu.Name = "chsachhu";
            this.chsachhu.Size = new System.Drawing.Size(159, 21);
            this.chsachhu.TabIndex = 0;
            this.chsachhu.Text = "Số sách hư cần thay";
            this.chsachhu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(9, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hiện có:";
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(93, 188);
            this.txttong.Margin = new System.Windows.Forms.Padding(4);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(101, 22);
            this.txttong.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dgvthongtin);
            this.groupBox2.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox2.Location = new System.Drawing.Point(-1, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(931, 383);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(229, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thống Kê Danh Sách Sách";
            // 
            // thongtinsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "thongtinsach";
            this.Text = "thongtinsach";
            this.Load += new System.EventHandler(this.thongtinsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthongtin;
        private System.Windows.Forms.CheckBox chsachkbd;
        private System.Windows.Forms.CheckBox chsachbandc;
        private System.Windows.Forms.CheckBox chsachhu;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
    }
}