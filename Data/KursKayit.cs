using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace efcoreApp.Data{

   public class KursKayit{
      
       [Key]
       [Display(Name ="Kayıt Id")]
      public int KayitId { get; set; }

      [Display(Name ="Öğrenci Adı")]
      public int OgrenciId { get; set; }

      public Ogrenci Ogrenci {get; set;} = null!;

      public int KursId { get; set; }

      public Kurs Kurs {get; set;} = null!;
      
      [Display(Name ="Kayıt Tarihi")]
      public DateTime KayitTarihi { get; set; }
   }

}