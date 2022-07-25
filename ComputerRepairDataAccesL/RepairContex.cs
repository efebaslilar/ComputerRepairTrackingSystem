using ComputerRepairTrackingSystem_Entites;
using ComputerRepairTrackingSystem_Entites.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairDataAccesL
{
    public class RepairContex : DbContext
    {
        //constructor yazdık base e connection string cümlesinin olduğu parametre adını verdik.
        public RepairContex() : base("name=MyCon")
        { }


        public virtual DbSet<ComputerRepair> ComputerRepairTable { get; set; }
    }
}
