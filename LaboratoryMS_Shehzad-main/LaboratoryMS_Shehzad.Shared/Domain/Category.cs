using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryMS_Shehzad.Shared.Domain
{
    public class Category
    {
        [Key]
        public string CatID { get; set; }
        public string CategoryName { get; set; }
    }
}
