using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace efcoreApp.Data{
    
    public class Kurs{

        [Display(Name ="Kurs Id")]
        public int KursId{get; set;}

        [Display(Name ="Kurs Adı")]
        public string? Baslik { get; set; }


        public int OgretmenId{get; set;}
        public Ogretmen Ogretmen {get; set;}= null!;
        
        public  ICollection<KursKayit> KursKayitlari {get; set;} = new List<KursKayit>();
 
    }



}