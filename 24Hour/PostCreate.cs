﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    /// <summary>
    /// I added
    /// </summary>

    // This model allows us to have some validation for the note properties
    // Annotations can be used to require or limit the number of characters in each field

    public class PostCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Text { get; set; }
    }
}

