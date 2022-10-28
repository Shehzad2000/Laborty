using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaboratoryMS_Shehzad.Shared.Domain
{
    public class TblTesting
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
