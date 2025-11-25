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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form form;

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = new FormSupplier();
            form.ShowDialog();
        }
    }
}
