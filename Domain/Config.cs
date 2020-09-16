using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Config
    {
        [Required]
        public string TF2Path { get; set; }
        [Required]
        public string TCPath { get; set; }
    }
}