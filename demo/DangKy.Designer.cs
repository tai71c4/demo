﻿namespace QuanLyCuaHangBanDoAnNhanh
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.lblDangKy = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.cboLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.BackColor = System.Drawing.Color.Transparent;
            this.lblDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangKy.Location = new System.Drawing.Point(283, 28);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(122, 32);
            this.lblDangKy.TabIndex = 0;
            this.lblDangKy.Text = "Đăng Ký";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(221, 107);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(153, 18);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "💁Tên Đăng Nhập :";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.Location = new System.Drawing.Point(221, 175);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(108, 18);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "🔑Mật Khẩu :";
            // 
            // lblNhapLaiMatKhau
            // 
            this.lblNhapLaiMatKhau.AutoSize = true;
            this.lblNhapLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapLaiMatKhau.Location = new System.Drawing.Point(221, 245);
            this.lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            this.lblNhapLaiMatKhau.Size = new System.Drawing.Size(179, 18);
            this.lblNhapLaiMatKhau.TabIndex = 3;
            this.lblNhapLaiMatKhau.Text = "🔒Nhập Lại Mật Khẩu :";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoai.Location = new System.Drawing.Point(221, 310);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(69, 18);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "📜Loại :";
            // 
            // btnDangKy
            // 
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDangKy.Location = new System.Drawing.Point(289, 393);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(85, 25);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThoat.Location = new System.Drawing.Point(389, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 25);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(224, 128);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(250, 22);
            this.txtTenDangNhap.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(224, 196);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(250, 22);
            this.txtMatKhau.TabIndex = 8;
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(224, 266);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(250, 22);
            this.txtNhapLaiMatKhau.TabIndex = 9;
            // 
            // cboLoaiTaiKhoan
            // 
            this.cboLoaiTaiKhoan.FormattingEnabled = true;
            this.cboLoaiTaiKhoan.Location = new System.Drawing.Point(224, 331);
            this.cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            this.cboLoaiTaiKhoan.Size = new System.Drawing.Size(250, 24);
            this.cboLoaiTaiKhoan.TabIndex = 10;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 514);
            this.Controls.Add(this.cboLoaiTaiKhoan);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblNhapLaiMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblDangKy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblNhapLaiMatKhau;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.ComboBox cboLoaiTaiKhoan;
    }
}