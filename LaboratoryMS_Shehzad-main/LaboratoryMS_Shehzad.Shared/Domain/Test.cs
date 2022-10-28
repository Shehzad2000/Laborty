using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMS_Shehzad.Shared.Domain
{
    public class Test
    {
        [Key]
        public string TestID { get; set; }
        public string TestName { get; set; }
        public string CatID { get; set; }
        public string UnitID { get; set; }
        public string NormalRange { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public DateTime TestDate { get; set; }
    }
}
