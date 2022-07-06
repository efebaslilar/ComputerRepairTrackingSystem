using ComputerRepairDataAccesL;
using ComputerRepairTrackingSystem_Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairEntityFrameworkCodeFirstBLL
{
    public class BrandManager
    {
        private RepairContex repairContex = new RepairContex();
        public List<Brand> GetBrand(int a)
        {
            try
            {
                List<Brand> data = repairContex.BrandTable.Where(x=>x.Id==a).ToList();
                return data;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public List<Brand> GetAllBrands()
        {
            try
            {
                List<Brand> data = repairContex.BrandTable.ToList();
                return data;
            }
            catch (Exception)
            {
                throw;
            }

        }

        
    }
}
