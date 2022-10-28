using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMS_Shehzad.Shared.Domain
{
    public class Unit
    {
        [Key]
        public string UnitID { get; set; }
        public string UnitName { get; set; }
    }
}
