using ComputerRepairEntityFrameworkCodeFirstBLL;
using ComputerRepairTrackingSystem_Entites.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerRepairTrackingSystem
{
    public partial class Waiting_Delivery : Form
    {
        public Waiting_Delivery()
        {
            InitializeComponent();
        }
        private ComputerRepairMenager repairMenager = new ComputerRepairMenager();
        private void Waiting_Delivery_Load(object sender, EventArgs e)
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource=repairMenager.GetAllRepair();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        private void btnTamirEdildi_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                repairMenager.Repaired(a);
                MessageBox.Show("Başarıyla Tamir Edildi.");
            }
            catch (Exception hata )
            {

                MessageBox.Show("Beklenmeyen Bir Hata Oluştu!"+ hata.Message);
            }
        }

        private void btnTamiratSil_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                repairMenager.IsDelete(a);
                MessageBox.Show("Başarıyla Silindi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik Bir Hata oluştu" + hata.Message);
            }
        }
    }
}

