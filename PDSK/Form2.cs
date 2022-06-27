using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee=new FrmEmployee();
            frmEmployee.MdiParent = this;
            frmEmployee.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment=new FrmDepartment();
            frmDepartment.MdiParent = this;
            frmDepartment.Show();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            FrmShift frmShift=new FrmShift();
            frmShift.MdiParent = this;
            frmShift.Show();
        }
    }
}
