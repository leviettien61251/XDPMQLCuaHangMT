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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        BUS_Account BUS_Account = new BUS_Account();
        Account account = new Account();
        private int roleId, employeeId;
        private string createdAt;
        public FormMain(Account account)
        {
            InitializeComponent();
            this.account = account;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            DataTable acccountInformation = BUS_Account.Login(this.account);
            foreach (DataRow row in acccountInformation.Rows)
            {
                roleId = Convert.ToInt32(row["RoleId"]);
                employeeId = Convert.ToInt32(row["EmployeeId"]);
                createdAt = row["CreatedAt"].ToString();
            }

            labelRoleId.Text = "Role ID: " + roleId.ToString();
            labelEmployeeId.Text = "Employee ID:" + employeeId.ToString();
            labelCreateAt.Text = "Created at: " + createdAt;

        }
        Form form;

        //private void formTestToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    form = new FormTest();
        //    form.ShowDialog();
        //}

        private void formToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form = new Form();
            switch (e.ClickedItem.Name)
            {
                case "FormTest":
                    FormTest F_Test = new FormTest();
                    form = F_Test;
                    break;
                case "FormSupplier":
                    FormSupplier F_Supplier = new FormSupplier();
                    form = F_Supplier;
                    break;
                default:
                    break;
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }

        //private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    form = new FormSupplier();
        //    form.ShowDialog();
        //}


    }
}
