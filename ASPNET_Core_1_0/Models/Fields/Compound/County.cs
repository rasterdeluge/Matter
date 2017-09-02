﻿using System.ComponentModel.DataAnnotations;

namespace ASPNET_Core_1_0.Models
{
    public class County
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Value { get; set; }

        [Required]
        [StringLength(60)]
        public string DisplayName { get; set; }

        public int StateId { get; set; }
    }
}
