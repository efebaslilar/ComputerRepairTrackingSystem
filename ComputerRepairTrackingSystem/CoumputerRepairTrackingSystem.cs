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
    public partial class CoumputerRepairTrackingSystem : Form
    {
        public CoumputerRepairTrackingSystem()
        {
            InitializeComponent();
        }

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            Form frm = new NewRepair();
            frm.ShowDialog();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            Form frm = new Waiting_Delivery();
            frm.ShowDialog();
        }

        private void btnPastRepair_Click(object sender, EventArgs e)
        {
            Form frm = new PastRepair();
            frm.ShowDialog();
        }

        private void CoumputerRepairTrackingSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
