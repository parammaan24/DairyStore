using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DairyStore.Models
{
    public class Order
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Contact")]
        public string Contact { get; set; }


        [Display(Name = "Dairy Item")]
        public string Ditem { get; set; }


        [Display(Name = "Qty")]
        public int Qty { get; set; }


        [Display(Name = "Quantity Type")]
        public string Qtype { get; set; }

        [Display(Name = "Date ")]
        public DateTime Dtime { get; set; }


        public Product product { get; set; }
    }
}
