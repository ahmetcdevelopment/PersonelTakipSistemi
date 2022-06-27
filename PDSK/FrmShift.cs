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
    public partial class FrmShift : Form
    {
        ShiftManager shiftManager;
        public FrmShift()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ShiftManager().Add(new Shift
            {
                Name = tbxSfiftName.Text,
                StartTime=tbxStartTime.Text,
                EndTime=tbxEndTime.Text,
            });
            MessageBox.Show("Başarıyla Eklendi");
            dgwShift.DataSource = shiftManager.GetAll();
        }

        private void FrmShift_Load(object sender, EventArgs e)
        {
            shiftManager=new ShiftManager(new EfShiftDal());
            dgwShift.DataSource=shiftManager.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?" +
                "", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                var selectedId = Convert.ToInt32(dgwShift.SelectedCells[0].Value);
                new ShiftManager().Delete(selectedId);
                MessageBox.Show("Başarıyla Silindi");
                dgwShift.DataSource = shiftManager.GetAll();

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //shiftManager = new ShiftManager(new EfShiftDal());
            var selectedId = Convert.ToInt32(dgwShift.SelectedCells[0].Value);
            shiftManager.Update(new Shift
            {
                Id = selectedId,
                Name = tbxSfiftName.Text,
                StartTime = tbxStartTime.Text,
                EndTime = tbxEndTime.Text,
            });
            MessageBox.Show("Başarıyla Güncellendi");
            dgwShift.DataSource = shiftManager.GetAll();
        }

        private void dgwShift_MouseClick(object sender, MouseEventArgs e)
        {
            tbxSfiftName.Text=dgwShift.CurrentRow.Cells[1].Value.ToString();
            tbxStartTime.Text=dgwShift.CurrentRow.Cells[2].Value.ToString();
            tbxEndTime.Text=dgwShift.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgwShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
