namespace nhom_9
{
    partial class frm_dang_nhap
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txt_tentaikhoan = new TextBox();
            txt_matkhau = new TextBox();
            frm_dangnhap = new Button();
            frm_thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new Point(51, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.R;
            pictureBox2.Location = new Point(51, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(51, 361);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txt_tentaikhoan
            // 
            txt_tentaikhoan.Location = new Point(118, 324);
            txt_tentaikhoan.Margin = new Padding(3, 2, 3, 2);
            txt_tentaikhoan.Name = "txt_tentaikhoan";
            txt_tentaikhoan.Size = new Size(296, 23);
            txt_tentaikhoan.TabIndex = 3;
            txt_tentaikhoan.Text = "admin";
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(118, 369);
            txt_matkhau.Margin = new Padding(3, 2, 3, 2);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '*';
            txt_matkhau.Size = new Size(296, 23);
            txt_matkhau.TabIndex = 4;
            txt_matkhau.Tag = "";
            txt_matkhau.Text = "12345";
            txt_matkhau.TextChanged += textBox1_TextChanged;
            // 
            // frm_dangnhap
            // 
            frm_dangnhap.Location = new Point(283, 444);
            frm_dangnhap.Name = "frm_dangnhap";
            frm_dangnhap.Size = new Size(137, 59);
            frm_dangnhap.TabIndex = 5;
            frm_dangnhap.Text = "Đăng Nhập";
            frm_dangnhap.UseVisualStyleBackColor = true;
            frm_dangnhap.Click += frm_dangnhap_Click;
            // 
            // frm_thoat
            // 
            frm_thoat.Location = new Point(51, 444);
            frm_thoat.Name = "frm_thoat";
            frm_thoat.Size = new Size(137, 59);
            frm_thoat.TabIndex = 6;
            frm_thoat.Text = "Thoát";
            frm_thoat.UseVisualStyleBackColor = true;
            frm_thoat.Click += frm_thoat_Click;
            // 
            // frm_dang_nhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 530);
            Controls.Add(frm_thoat);
            Controls.Add(frm_dangnhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_tentaikhoan);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            IsMdiContainer = true;
            MinimizeBox = false;
            Name = "frm_dang_nhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += frm_dang_nhap_FormClosing;
            FormClosed += frm_dang_nhap_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txt_tentaikhoan;
        private TextBox txt_matkhau;
        private Button frm_dangnhap;
        private Button frm_thoat;
    }
}