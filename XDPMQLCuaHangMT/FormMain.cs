using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;
using XDPMQLCuaHangMT.UI_UPDATE;
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
        private void formToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormSupplier_Click(object sender, EventArgs e)
        {
        }

        private void FormVoucherIN_Click(object sender, EventArgs e)
        {
            FormVoucherIN F_VoucherIN = new FormVoucherIN();
            F_VoucherIN.MdiParent = this;
            F_VoucherIN.WindowState = FormWindowState.Maximized;
            F_VoucherIN.Show();
            F_VoucherIN.BringToFront();
        }

        private void FormVoucherIN_Click_1(object sender, EventArgs e)
        {
            FormVoucherIN F_VoucherIN = new FormVoucherIN(employeeId, "Phiếu nhập kho");
            F_VoucherIN.MdiParent = this;
            F_VoucherIN.WindowState = FormWindowState.Maximized;
            F_VoucherIN.Show();
        }

        private void FormVoucherOUT_Click(object sender, EventArgs e)
        {
            FormVoucherOUT F_VoucherOUT = new FormVoucherOUT(employeeId, "Phiếu xuất kho");
            F_VoucherOUT.MdiParent = this;
            F_VoucherOUT.WindowState = FormWindowState.Maximized;
            F_VoucherOUT.Show();
            F_VoucherOUT.BringToFront();
        }

        private void ManagementToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form = new Form();
            switch (e.ClickedItem.Name)
            {
                case "FormAccount":
                    AccountForm F_Account = new AccountForm(employeeId);
                    form = F_Account;
                    break;
                case "FormEmployee":
                    EmployeeForm F_Employee = new EmployeeForm(employeeId);
                    form = F_Employee;
                    break;
                case "FormSupplier":
                    SupplierForm F_Supplier = new SupplierForm();
                    form = F_Supplier;
                    break;
                case "FormStock":
                    Form_Stock F_Stock = new Form_Stock(employeeId);
                    form = F_Stock;
                    break;
                default:
                    break;
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }
    }
}
