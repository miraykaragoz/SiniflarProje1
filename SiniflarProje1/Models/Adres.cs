using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarProje1.Models
{
    public class Adres : BaseModel
    {
        public string Sehir {  get; set; }
        public string Ilce { get; set; }
        public int PostaKodu { get; set; }
        public string Tarif {  get; set; }
        public bool IsPrimary { get; set; } = true;
    }
}
