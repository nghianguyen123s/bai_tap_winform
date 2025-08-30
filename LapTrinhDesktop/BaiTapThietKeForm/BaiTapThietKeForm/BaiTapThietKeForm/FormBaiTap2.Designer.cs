namespace BaiTapThietKeForm
{
    partial class FormBaiTap2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonhang = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTien = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChonhang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.lbDanhSach);
            this.panel1.Location = new System.Drawing.Point(44, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 367);
            this.panel1.TabIndex = 0;
            // 
            // btnChonhang
            // 
            this.btnChonhang.Location = new System.Drawing.Point(196, 150);
            this.btnChonhang.Name = "btnChonhang";
            this.btnChonhang.Size = new System.Drawing.Size(116, 30);
            this.btnChonhang.TabIndex = 3;
            this.btnChonhang.Text = "Chọn hàng >>";
            this.btnChonhang.UseVisualStyleBackColor = true;
            this.btnChonhang.Click += new System.EventHandler(this.btnChonhang_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB KingMax"});
            this.listBox1.Location = new System.Drawing.Point(30, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 212);
            this.listBox1.TabIndex = 2;
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.AutoSize = true;
            this.lbDanhSach.Location = new System.Drawing.Point(27, 32);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(138, 16);
            this.lbDanhSach.TabIndex = 0;
            this.lbDanhSach.Text = "Danh Sách Hàng Hóa";
            this.lbDanhSach.Click += new System.EventHandler(this.lbDanhSach_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTien);
            this.panel2.Controls.Add(this.lbTongtien);
            this.panel2.Controls.Add(this.btnTinhtien);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(412, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 367);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTien.Location = new System.Drawing.Point(205, 330);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(15, 16);
            this.lbTien.TabIndex = 6;
            this.lbTien.Text = "$";
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongtien.Location = new System.Drawing.Point(3, 330);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(172, 16);
            this.lbTongtien.TabIndex = 5;
            this.lbTongtien.Text = "Tổng số tiền thanh toán:";
            this.lbTongtien.Click += new System.EventHandler(this.lbTongtien_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Location = new System.Drawing.Point(142, 284);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(96, 30);
            this.btnTinhtien.TabIndex = 4;
            this.btnTinhtien.Text = "Tính Tiền";
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(20, 150);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(116, 30);
            this.btnBoHang.TabIndex = 3;
            this.btnBoHang.Text = "<< Bỏ Hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "Chuột",
            "USB KingMax",
            "USB KingMax"});
            this.listBox2.Location = new System.Drawing.Point(142, 65);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(160, 212);
            this.listBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mặt Hàng Đã Mua";
            // 
            // FormBaiTap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBaiTap2";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.FormBaiTap2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbDanhSach;
        private System.Windows.Forms.Button btnChonhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.Label lbTien;
    }
}