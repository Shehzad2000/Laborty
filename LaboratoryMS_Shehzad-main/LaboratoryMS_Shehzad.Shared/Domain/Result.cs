using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMS_Shehzad.Shared.Domain
{
    public class Result
    {
        [Key]
        public string ResultID { get; set; }
        public string TestID { get; set; }
        public int RecieptID { get; set; }
        public string ResultValue { get; set; }
        public DateTime ResultDate { get; set; }
    }
}
