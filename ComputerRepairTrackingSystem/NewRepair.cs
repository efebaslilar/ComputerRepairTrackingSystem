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
    public partial class NewRepair : Form
    {
        public NewRepair()
        {
            InitializeComponent();
        }
        
        ComputerRepairMenager computerRepairMenager = new ComputerRepairMenager();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComputerRepair a = new ComputerRepair()
                {
                    PersonName = txtboxNameAddPerson.Text,
                    PersonPhone = txtboxPhoneAddPerson.Text,
                    Price = txtPriceAddPerson.Text,
                    Brand = txtBrandAddPerson.Text,
                    Problem = richTextBox2.Text,
                    RecordOfDateTime = DateTime.Now.ToString("hh-mm dd-MM-yyyy")
                };
                computerRepairMenager.AddRepair(a);
                MessageBox.Show("Başarıyla Kaydedildi");
                ClearAll();

            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmeyen Bir hata oluştu.");;
            }
            
        }

      

        public void ClearAll()
        {   
            foreach (var item in this.Controls)
            {
                if (item is TextBox )
                {
                   ((TextBox)item).Clear();
                }
                if (item is RichTextBox)
                {
                    ((RichTextBox)item).Clear();
                }
            }
        }

      
    }
}
