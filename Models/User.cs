using System;
using System.ComponentModel.DataAnnotations;

namespace dojo_survey_vals.Models
{
    public class User
    {
        // ~~~~~~~~~~Fields~~~~~~~~~~
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name")] 
        public string FullName { get; set; }
        
        // no vals needed because we'll use selectors
        [Display(Name = "Dojo Location")] 
        public string Location { get; set; }
        
        // no vals needed because we'll use selectors
        [Display(Name = "Favorite Language")] 
        public string Language {get; set;}

        // Optional or Min X can be achieved like this! (leave out [Required] and put a min length)
        [MinLength(10)]
        [Display(Name = "Comment (Optional)")] 
        public string Comment {get; set;}
    }
}