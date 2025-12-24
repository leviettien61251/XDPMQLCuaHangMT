using System.Windows.Forms;

namespace XDPMQLCuaHangMT.UI_UPDATE
{
    public partial class Form_Stock : Form
    {
        protected int employeeId;
        public Form_Stock()
        {
            InitializeComponent();
        }
        public Form_Stock(int employeeId_)
        {
            InitializeComponent();
            this.employeeId = employeeId_;
        }
        private void Form_Stock_Load(object sender, System.EventArgs e)
        {

        }
    }
}
