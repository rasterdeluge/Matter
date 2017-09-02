using System.ComponentModel.DataAnnotations;

namespace ASPNET_Core_1_0.Models
{
    public class Shipper
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Value { get; set; }

        [Required]
        [StringLength(60)]
        public string DisplayName { get; set; }
    }
}
