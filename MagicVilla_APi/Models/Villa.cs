using System.ComponentModel.DataAnnotations;

namespace MagicVilla_APi.Models
{
    public class Villa
    {
        [Key]
        public int    Id { get; set; }
        [Required]
        public string OwnerName { get; set; }
        public string Description { get; set; }
        public double area { get; set; }
        public int    numOFrooms {  get; set; } 
        public string city { get; set; }
        public string StreetName { get; set; }
        public int    villaNum { get; set; }
        public double price { get; set; }
        public string imageUrl { get; set; }
        public DateTime CreatedDate { get; set; }  
        public DateTime UpdatedDate { get; set;}

    }
}
