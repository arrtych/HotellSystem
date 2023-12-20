using System.ComponentModel.DataAnnotations;

namespace HotellSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        //[MaxLength(11)]
        public string PersonalCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public double Budget { get; set; } = 0;

        public List<Reservation> reservations = new List<Reservation>();




    }
}
