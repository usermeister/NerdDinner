using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NerdDinner.Models
{
    [MetadataType(typeof(Dinner_Validation))]
    public partial class Dinner
    {
        //...
    }
    public class Dinner_Validation
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title may not be longer than 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(256, ErrorMessage =
          "Description must be 256 characters or less")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone# is required")]
        public string ContactPhone { get; set; }
    }
}