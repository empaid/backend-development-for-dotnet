using System.ComponentModel.DataAnnotations;

namespace backend_development_for_dotnet.Models
{
    public class Account
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string? Username {get; set;}
        [Required]
        [MinLength(8)]
        [MaxLength(20)]
        public string? Password {get; set;}

        [Range(18, 60)]
        public int Age {get; set;}
        [Required]
        [EmailAddress]
        public string? Email {get; set;}
        [Url]
        public string? Website{get; set;}

    }
}