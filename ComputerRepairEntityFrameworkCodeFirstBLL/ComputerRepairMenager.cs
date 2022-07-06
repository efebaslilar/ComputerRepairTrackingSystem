using ComputerRepairTrackingSystem_Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerRepairTrackingSystem_Entites.Entities;
using ComputerRepairDataAccesL;

namespace ComputerRepairEntityFrameworkCodeFirstBLL
{
    public class ComputerRepairMenager
    {
        private RepairContex repairContex = new RepairContex();
        public List<ComputerRepair> GetAllRepair()
        {
            try
            {
                List<ComputerRepair> data = repairContex.ComputerRepairTable.Where(x=> !x.IsDelete && !x.Repaired).ToList();
                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<ComputerRepair> GetAllPastRepair()
        {
            try
            {
                List<ComputerRepair> data = repairContex.ComputerRepairTable.Where(x => !x.IsDelete && x.Repaired).ToList();
                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void AddRepair(ComputerRepair repair)
        {
            try
            {
                repairContex.ComputerRepairTable.Add(repair);
                repairContex.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Repaired(int id)
        {
            try
            {
                ComputerRepair a = repairContex.ComputerRepairTable.FirstOrDefault(x => x.Id == id);
                a.Repaired = true;
                repairContex.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void IsDelete(int id)
        {
            try
            {
                ComputerRepair a = repairContex.ComputerRepairTable.FirstOrDefault(x => x.Id == id);
                a.IsDelete = true;
                repairContex.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
