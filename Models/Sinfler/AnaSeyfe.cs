using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje1.Models.Sinfler
{
    public class AnaSeyfe
    {
        [Key]
        public int ID { get; set; }
        public string Baslig { get; set; }
        public string Aciqlama { get; set; }
    }
}