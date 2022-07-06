using ComputerRepairEntityFrameworkCodeFirstBLL;
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
    public partial class PastRepair : Form
    {
        public PastRepair()
        {
            InitializeComponent();
        }

        private void PastRepair_Load(object sender, EventArgs e)
        {
            ComputerRepairMenager menager = new ComputerRepairMenager();
            dataGridView1.DataSource= menager.GetAllPastRepair();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
    }
}
