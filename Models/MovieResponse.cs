using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_jrencher.Models

    //Creates a movie responce model that is used for each movie entry.
{
    public class MovieResponse
    {
        //Building the foreign key relationship
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        [Key]
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo {get; set;}
        [StringLength(25)]
        public string Notes { get; set; }

    }
}

//Needed Variables, their options, and required status.
//Category
//Title
//Year
//Director
//Rating (Dropdown G, PG, PG-13, R)
//Edited (yes or no) (optional)
//Lent To: (optional)
//Notes (optional)(25 char limit)
