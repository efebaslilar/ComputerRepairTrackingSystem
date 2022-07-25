using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairTrackingSystem_Entites.Entities
{
    [Table("ComputerRepairs")]
    public class ComputerRepair
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PersonName { get; set; }

        public string PersonPhone { get; set; }

        public string Brand { get; set; }

        public string Price { get; set; }

        public string Problem { get; set; }

        public bool Repaired { get; set; }

        public bool IsDelete { get; set; }
        public string RecordOfDateTime { get; set; } 

        

    

    }
}
