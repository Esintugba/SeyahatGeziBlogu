using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatGeziWebProje.Models.Siniflar
{
    public class Restoranlar
    {
        [Key]
        public int ID { get; set; }
        public string RestoranAdı { get; set; }
        public string Adres { get; set; }
    }
}