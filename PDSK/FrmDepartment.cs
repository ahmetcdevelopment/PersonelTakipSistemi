using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class FrmDepartment : Form
    {
        DepartmentManager departmentManager;
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //departmentManager = new DepartmentManager(new EfDepartmentDal());
            new DepartmentManager().Add(new Department
            {
                Name =tbxDepartmentName.Text,
            });
            MessageBox.Show("Departman Başarıyla Eklendi");
            dgwDepartment.DataSource = departmentManager.GetAll();

        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            dgwDepartment.DataSource=new DepartmentManager().GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedId=Convert.ToInt32(dgwDepartment.SelectedCells[0].Value);
            new DepartmentManager().Delete(selectedId);
            MessageBox.Show("Departman Başarıyla Silindi");
            dgwDepartment.DataSource = new DepartmentManager().GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedId = Convert.ToInt32(dgwDepartment.SelectedCells[0].Value);
            new DepartmentManager().Update(new Department
            {
                Id=selectedId,
                Name=tbxDepartmentName.Text,
            });
            MessageBox.Show("Departman Güncellendi");
            dgwDepartment.DataSource=departmentManager.GetAll();
        }
    }
}
