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
        BrandManager brandManager = new BrandManager();
        ComputerRepairMenager computerRepairMenager = new ComputerRepairMenager();

      private void NewRepair_Load(object sender, EventArgs e)
        {
            GetBrandIdAndNameToCombo();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComputerRepair a = new ComputerRepair()
                {
                    PersonName = txtboxNameAddPerson.Text,
                    PersonPhone = txtboxPhoneAddPerson.Text,
                    BrandId = Convert.ToInt32(comboBox1.SelectedValue),
                    Problem = richTextBox2.Text,
                    RecordOfDateTime = DateTime.Now.ToString("dd-MM-yyyy")
                };
                computerRepairMenager.AddRepair(a);
                MessageBox.Show("Başarıyla Kaydedildi");
                ClearAll();

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void GetBrandIdAndNameToCombo()
        {
            
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember="Id";
            comboBox1.DataSource = brandManager.GetAllBrands();
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
            comboBox1.SelectedIndex = 0;
            
        }

      
    }
}
