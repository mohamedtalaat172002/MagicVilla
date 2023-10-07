using System.ComponentModel.DataAnnotations;

namespace MagicVilla_APi.Models.Dtos
{
    public class VillaDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string OwnerName { get; set; }
        public string Description { get; set; }
        public double area { get; set; }
        public int numOFrooms { get; set; }
        public string city { get; set; }
        public string StreetName { get; set; }
        public int villaNum { get; set; }
        public double price { get; set; }
        public string imageUrl { get; set; }
    }
}
