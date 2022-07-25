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
            GetDataGridRepairData();
        }

        private void btnTamirEdildi_Click(object sender, EventArgs e)
        {
            try
            {
                int a= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                 repairMenager.Repaired(a);
                MessageBox.Show("Başarıyla Tamir Edildi.");
                GetDataGridRepairData();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmeyen Bir Hata Oluştu!" + hata.Message);
            }
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    repairMenager.IsDelete(id);
                    MessageBox.Show("Başarıyla Silinmiştir !");
                GetDataGridRepairData();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oldu!"+hata.Message);
            }
        }

        public void GetDataGridRepairData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repairMenager.GetAllRepair();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                ComputerRepair dataRepair = new ComputerRepair()
                {
                    PersonName= (string)dataGridView1.Rows[0].Cells["PersonName"].Value,
                    Brand = (string)dataGridView1.Rows[0].Cells["Brand"].Value,
                    PersonPhone = (string)dataGridView1.Rows[0].Cells["PersonName"].Value,
                    Price = (string)dataGridView1.Rows[0].Cells["PersonName"].Value,
                    Problem = (string)dataGridView1.Rows[0].Cells["PersonName"].Value,
                };
                repairMenager.UpdateDatabyId(dataRepair, Convert.ToInt32(dataGridView1.Rows[0].Cells["Id"].Value));
            }
            MessageBox.Show("Bilgiler Güncellenmiştir.");
            GetDataGridRepairData();
        }

    }
}

