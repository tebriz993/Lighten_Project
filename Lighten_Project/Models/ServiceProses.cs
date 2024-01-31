using Lighten_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lighten_Project.Models
{
    public class ServiceProses
    {
        [Key]
        public int Id { get; set; }
        
        public string Icon { get; set; }

       
        [MaxLength(50, ErrorMessage = "Simvol sayi 50-den cox ola bilmez")]
        public string Title { get; set; }

        
        [MaxLength(400, ErrorMessage = "Simvol sayi 400-den cox ola bilmez")]
        public string UpTitle { get; set; }

    }
}
