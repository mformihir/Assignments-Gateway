using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web;
using DataAnnotationsExample.CustomAttribute;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationsExample.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3-30 characters.")]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage = "Age must be between 1-100 year(s).")]
        public int Age { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [RegularExpression(@"^([0-9a-z_.])+$", ErrorMessage = "Username can only contain lowercase letters, numbers, period(.) and underscore(_)")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [CreditCard]
        public string CreditCard { get; set; }

        [NotMapped]
        [FileExtensions(Extensions = ".jpg,.png")]
        public HttpPostedFileBase File { get; set; }

        [CustomAttribute.Continent("Asia")]
        public string Continent { get; set; }
    }

    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}