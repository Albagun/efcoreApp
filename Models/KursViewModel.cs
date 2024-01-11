using System.ComponentModel.DataAnnotations;
using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace efcoreApp.Models{
    
    public class KursViewModel{
        public int KursId{get; set;}

        [Required]
        [StringLength(50,ErrorMessage ="Harf Sınırını geçtiniz...")]
        public string? Baslik { get; set; }


        public int OgretmenId{get; set;}
        
        public  ICollection<KursKayit> KursKayitlari {get; set;} = new List<KursKayit>();
       
 
    }



}