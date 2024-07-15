using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using efcoreApp.Data;

namespace efcoreApp.Models
{
    public class KursViewModel
    {
        [Key]
        public int KursId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Kurs Başlığı")]
        public string? Baslik { get; set; }

        public int OgretmenId { get; set; }    

        // public Ogretmen Ogretmen { get; set; } = null!;

        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }

}