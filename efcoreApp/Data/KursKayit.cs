using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId { get; set; }

        public int OgrenciId { get; set; }

        public Ogrenci Ogrenci { get; set; } = null!; //Burayı tam anlamadım. Öğrenci tablosu ile bir ilişki kurmak için oluşturduk. Navigation Property. 

        public int KursId { get; set; }

        public Kurs Kurs { get; set; } = null!; // Kurs tablosuna erişmek için oluşturduk. Navigation Property.

        public DateTime KayitTarihi { get; set; }

        
    }
}