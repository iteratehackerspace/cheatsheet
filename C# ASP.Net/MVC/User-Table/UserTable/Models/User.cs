using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserTable.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Priority { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [StringLength(128, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 128")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Range(1, 99, ErrorMessage = "Age must be positive and less than 100")]
        public int? Age { get; set; }

        public List<int> UserIds { get; set; }
    }
}