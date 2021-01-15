using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cloud_app.Domain
{
    public class Data
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int Value { get; set; }
        [NotMapped]
        public String Host { get; set; }
    }
}
