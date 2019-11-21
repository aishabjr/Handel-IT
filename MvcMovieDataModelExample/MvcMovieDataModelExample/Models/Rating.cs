using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MvcMovieDataModelExample.Models
{
    public class Rating
    {
        public int ID { get; set; }

        [Display(Name = "Rating")]
        [MaxLength(64, ErrorMessage = "Maximum length of 64 characters")]
        [Required(ErrorMessage = "Please enter a rating.")]
        public string RatingName { get; set; }

        [Display(Name = "Last Modified Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime? LastModified { get; set; }
        [Display(Name = "Last Modified By")]
        public string LastModifiedBy { get; set; }
    }
}