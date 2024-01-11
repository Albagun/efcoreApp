using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace efcoreApp.Data{

   public class Ogretmen {
     
     [Key]
     [Display(Name ="Öğretmen Id")]
     public int OgretmenId { get; set; }
    public string? Ad { get; set; }
    public string? Soyad { get; set; }

    [Display(Name ="Öğretmenin Adı Soyadı" )]
      public string AdSoyad {
            get
            {
              return this.Ad +" "+ this.Soyad;
            }
}
    public string? Eposta { get; set; }
    public string? Telefon { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode =false)]

    [Display(Name ="Başlama Tarihi")]
    public DateTime BaslamaTarihi { get; set; }

    public ICollection<Kurs> Kurslar {get; set;} = new List<Kurs>();


   }


}