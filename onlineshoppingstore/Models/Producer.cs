using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlineshoppingstore.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        [Required]
        [StringLength(160, MinimumLength = 3)]
        public string Name { get; set; }
    }
}