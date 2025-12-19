using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "First number is required")]
        [Display(Name = "First Number")]
        public double Number1 { get; set; }

        [Required(ErrorMessage = "Second number is required")]
        [Display(Name = "Second Number")]
        public double Number2 { get; set; }

        [Required(ErrorMessage = "Please select an operation")]
        [Display(Name = "Operation")]
        public string Operation { get; set; }

        public double? Result { get; set; }

        public string ErrorMessage { get; set; }
    }
}