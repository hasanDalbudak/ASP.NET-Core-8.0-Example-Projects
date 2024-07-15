using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace efcoreApp.Data
{
    public class Ogrenci //bu tanımladığımız class veri tabanındaki bir tabloya karşılık gelir
    {
        // id => primary key
        [Key]
        public int OgrenciId { get; set; }

        public string? OgrenciAd { get; set; }

        public string? OgrenciSoyad { get; set; }

        public string? AdSoyad {
             get
             {
                return this.OgrenciAd + " " + this.OgrenciSoyad;
             }
        }

        public string? Eposta { get; set; }
        
        public string? Telefon { get; set; }   

        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();

    }
}