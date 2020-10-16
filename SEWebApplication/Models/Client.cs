using System;
using System.ComponentModel.DataAnnotations;

namespace SEWebApplication.Models
{
    public class Client
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Email { get; set; }
        [Required]
        [MaxLength(516)]
        public string Description { get; set; }
        [MaxLength(128)]
        public string Telephone { get; set; }
        [Required]
        public int Rate { get; set; }
        [MaxLength(128)]
        public string Payment { get; set; }
        public bool IsTest { get; set; }
        [Required]
        [MaxLength(128)]
        public string Exprise { get; set; }
    }
}
