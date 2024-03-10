using System.ComponentModel.DataAnnotations;

namespace sqlapp.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Name of product")]
        [Required(ErrorMessage = "Please fill in the field {0}\r\n ", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please fill in the field {0} it must contain from 5 to a maximum of 25\r\n")]
        public string ProductName { get; set; } = string.Empty;

        [Display(Name = "Description of product")]
        [Required(ErrorMessage = "Please fill in the field {0}\r\n ", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please fill in the field {0} it must contain from 5 to a maximum of 100\r\n")]
        public string ProductDescription { get; set; } = string.Empty;

        [Display(Name = "Quantity", Description = "The value must be between 0 and 2147483647\r\n")]
        [Range(0, 2147483647)]
        public int Quantity { get; set; }

        [Key]
        public int ProductCategoryID { get; set; }

        [Display(Name = "Category of product")]
        [Required(ErrorMessage = "Please fill in the field {0}\r\n ", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please fill in the field {0} it must contain from 5 to a maximum of 100\r\n")]
        public string ProductCategory { get; set; } = string.Empty;


    }
}
