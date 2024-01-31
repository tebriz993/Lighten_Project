using System.ComponentModel.DataAnnotations;

namespace Lighten_Project.Models
{
    public class OurProducts
    {
        [Key]
        public int Id { get; set; }
       
        public string Picture { get; set; }

        
        [MaxLength(60, ErrorMessage = "Simvol sayi 60-den cox ola bilmez")]
        public string Title { get; set; }

        
        public string Price  { get; set; }

    }
}
