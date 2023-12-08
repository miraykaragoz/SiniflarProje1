using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarProje1.Models
{
    public class Urun : BaseModel
    {
        public Kategori Kategori { get; set; }
        public float Fiyat {  get; set; }
        public string Aciklama { get; set; }
        public List<Foto> Fotolar { get; set; } = new List<Foto>();
    }
}
