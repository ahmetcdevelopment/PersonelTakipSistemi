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
    public partial class FrmEmployee : Form
    {
        EmployeeManager employeeManager;
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            employeeManager = new EmployeeManager(new EfEmployeeDal());
            dgwEmployee.DataSource = employeeManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new EmployeeManager().Add(new Employee
            {
                DepartmentId = Convert.ToInt32(tbxDepartment.Text),
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text
            });
            dgwEmployee.DataSource=employeeManager.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedId = Convert.ToInt32(dgwEmployee.SelectedCells[0].Value);
            var selectedDepartment = Convert.ToInt32(tbxDepartment.Text);
            var selectedName = tbxFirstName.Text;
            var selectedLastName=tbxLastName.Text;
            new EmployeeManager().Update(new Employee { 
                Id=selectedId,
                DepartmentId=selectedDepartment,
                FirstName=selectedName,
                LastName=selectedLastName});
            MessageBox.Show("Güncellendi");
            dgwEmployee.DataSource = employeeManager.GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?" +
                "","Silme İşlemi",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                var selectedId = Convert.ToInt32(dgwEmployee.SelectedCells[0].Value);
                new EmployeeManager().Delete(selectedId);
                MessageBox.Show("silindi");
                dgwEmployee.DataSource = employeeManager.GetAll();
            }
            
        }

        private void tbxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            List<Employee> _employees = employeeManager.GetAll().ToList();
            var filteredData = _employees.Where(p => p.FirstName.Contains(tbxSearchEmployee.Text,
                StringComparison.OrdinalIgnoreCase) || p.LastName.Contains(tbxSearchEmployee.Text,
                StringComparison.OrdinalIgnoreCase)).ToList();
            dgwEmployee.DataSource = filteredData;
            
        }

        private void dgwEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgwEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            tbxDepartment.Text = dgwEmployee.CurrentRow.Cells[1].Value.ToString();
            tbxFirstName.Text = dgwEmployee.CurrentRow.Cells[2].Value.ToString();
            tbxLastName.Text = dgwEmployee.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
