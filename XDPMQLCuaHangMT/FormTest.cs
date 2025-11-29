using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }
        Account account;
        BUS_Account busAccount = new BUS_Account();
        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void buttonTestAdd_Click(object sender, EventArgs e)
        {
            string username = textBoxTestAdd.Text;
            string password = textBoxTestPass.Text;
            int roleId = int.Parse(textBoxRole.Text);
            int employeeId = int.Parse(textBoxEmployee.Text);
            

            PasswordHash hash = new PasswordHash(password);
            password = hash.Hash();
            account = new Account
            {
                username = username,
                password = password,
                roleId = roleId,
                employeeId = employeeId
            };
            MessageBox.Show("Hashed password: " + password);
            if (busAccount.InsertAccount(account))
            {
                MessageBox.Show("Add account successful.");
            }
            else
            {
                MessageBox.Show("Add account failed.");
            }
        }
    }
}
