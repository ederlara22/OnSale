using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace OnSale.common.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
