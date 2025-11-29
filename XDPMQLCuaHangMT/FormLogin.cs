using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace XDPMQLCuaHangMT
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Account account;
        BUS_Account BUS_Account = new BUS_Account();
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            account = new Account(username, password);
            if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
            {
                if (BUS_Account.Login(account).Rows.Count == 1)//Check if login is return 1 row
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormMain formMain = new FormMain(account);
                    formMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearFields();

        }

        private void ClearFields()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
