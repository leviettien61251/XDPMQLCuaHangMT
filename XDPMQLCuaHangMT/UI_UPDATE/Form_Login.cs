using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT.UI_UPDATE
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        Account account;
        BUS_Account BUS_Account = new BUS_Account();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            account = new Account(username, password);
            if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
            {
                if (BUS_Account.Login(account).Rows.Count == 1)//Check if login is return 1 row
                {
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
