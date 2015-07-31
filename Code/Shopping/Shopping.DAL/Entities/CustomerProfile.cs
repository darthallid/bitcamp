using Shopping.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.DAL.Entities
{
    public class CustomerProfile
    {
        [ForeignKey("Customer")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public CustomerType Type { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
