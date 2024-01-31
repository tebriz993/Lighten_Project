using System.ComponentModel.DataAnnotations;

namespace Lighten_Project.Models
{
    public class Blogs
    {
        [Key]
        public int Id { get; set; }
        
        public string Picture { get; set; }

       
        [MaxLength(50, ErrorMessage = "Simvol sayi 50 simvoldan cox ola bilmez")]
        public string Title { get; set; }
       
        public string Date { get; set; }
        
        [MaxLength(400, ErrorMessage = "Simvol sayi 400-den cox ola bilmez")]
        public string UpTitle { get; set; }
    }
}
