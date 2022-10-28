using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMS_Shehzad.Shared.Domain
{
    public class TestPrice
    {
        [Key]
        public string TestPriceID { get; set; }
        public string TestID { get; set; }
        public int Price { get; set; }
    }
}
