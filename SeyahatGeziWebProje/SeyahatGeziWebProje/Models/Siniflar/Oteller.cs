using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatGeziWebProje.Models.Siniflar
{
    public class Oteller
    {
        [Key]
        public int ID { get; set; }
        public string OtelAd { get; set; }
        public int Fiyat { get; set; }
        public string Adres { get; set; }
    }
}