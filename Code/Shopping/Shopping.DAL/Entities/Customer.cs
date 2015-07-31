using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.DAL.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
            }
        }

        [Required]
        [MaxLength(128)]
        [Index(IsUnique = true)]
        public string EmailAddress { get; set; }

        public virtual CustomerProfile Profile { get; set; }

        public virtual IList<Order> Orders { get; set; }
    }
}
