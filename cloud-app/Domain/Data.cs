using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cloud_app.Domain
{
    public class Data
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int Value { get; set; }
    }
}
