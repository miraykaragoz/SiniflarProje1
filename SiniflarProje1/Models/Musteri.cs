using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarProje1.Models
{
    [Table("Musteriler")]
    public class Musteri : BaseModel
    {
        public string Soyad { get; set; }
        public int TCKN { get; set; }
        public string GSM { get; set; }
        public Cinsiyet Cinsiyet { get; set; } = new Cinsiyet();
        public List<Adres> Adresler { get; set; } = new List<Adres>();
        public List<Siparis> Siparisler { get; set; } = new List<Siparis>();
    }
}
