

using System;
using System.ComponentModel.DataAnnotations;

namespace AltinayStaj2.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        
    }

}
