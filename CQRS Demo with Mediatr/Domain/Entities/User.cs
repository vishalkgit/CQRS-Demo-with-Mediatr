using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CQRS_Demo_with_Mediatr.Domain.Entities
{
    public class User
    {
        [Key]
        public int UId { get; set; }

        public String? UName { get; set; }

        [Required]
        [Range(1, 100)]
        public int Age { get; set; } = 18;

    }
}
