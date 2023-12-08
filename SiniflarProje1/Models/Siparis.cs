using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarProje1.Models
{
    public class Siparis : BaseModel
    {
        public List<Urun> Urunler {  get; set; }
    }
}
