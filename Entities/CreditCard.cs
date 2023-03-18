using System.ComponentModel.DataAnnotations;

namespace Alta.Entities
{
    public class CreditCard
    {
        [Required(ErrorMessage = "Card Number is required")]
        [StringLength(16, ErrorMessage = "Card Number must be 16 digits")]
        [MinLength(16, ErrorMessage = "Card Number must be 16 digits")]
        [MaxLength(16, ErrorMessage = "Card Number must be 16 digits")]
        public string Number { get; set; } = string.Empty;


        [Required(ErrorMessage = "Card Name is required")]
        [MinLength(1, ErrorMessage = "Name must not be empty")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = "Card Date is required")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/2024", "1/1/2030", ErrorMessage = "Please enter a date between {1:d} and {2:d}.")]
        public DateTime Date { get; set; } = DateTime.Today;


        [Required(ErrorMessage = "Card CVV is required")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Please enter a valid 3-digit number.")]
        public int Cvv { get; set; }

        public bool IsCredit { get; set; } = true;
    }
}
