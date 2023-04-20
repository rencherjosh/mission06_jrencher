﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_jrencher.Models
{
    public class MovieResponse
    {
        [Required]
        public string Category { get; set; }
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

//Category
//Title
//Year
//Director
//Rating (Dropdown G, PG, PG-13, R)
//Edited (yes or no) (optional)
//Lent To: (optional)
//Notes (optional)(25 char limit)
