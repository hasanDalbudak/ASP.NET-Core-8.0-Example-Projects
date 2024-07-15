using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Kurs
    {
        [Key]
        public int KursId { get; set; }

        [Display(Name = "Kurs Başlığı")]
        public string? Baslik { get; set; }

        public int OgretmenId { get; set; }    

        public Ogretmen Ogretmen { get; set; } = null!; //Kurs tablosunda öğretmen id olacak bu satır sayesinde. Yani 1 kursu yalnızda 1 öğretmen verebilir. Birden fazla vermesini isteseydik List olarak kayıt ederdik.

        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();

        // Bir kursu yalnızca 1 adet eğitmen verebilir.
        // Bir eğitmen birden fazla kurs verebebilir.
    }

}