﻿using StoreManagement.BUS;
using StoreManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private const string defaultUsernameText = " Username";
        private const string defaultPasswordText = " Password";


        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            if (testCbx.Checked)
            {
                NhanVienBUS.Instance.GetNhanVien("testing");
                Hide();
                home.ShowDialog();
                Close();
                return;
            }
            if (tbxTaiKhoan.Text == defaultUsernameText || tbxMatKhau.Text == defaultPasswordText)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxTaiKhoan.Text.Trim() == "" || tbxMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin đăng nhập không thể bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxTaiKhoan.Text[0] == ' ' || tbxMatKhau.Text[0] == ' ')
            {
                MessageBox.Show("Thông tin đăng nhập không thể bắt đầu bằng phím cách (space key)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (TaiKhoanBUS.Instance.LoginMethod(tbxTaiKhoan.Text, tbxMatKhau.Text) == true)
                {
                    NhanVienBUS.Instance.GetNhanVien(tbxTaiKhoan.Text);
                    Hide();
                    home.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
