using System;
using System.ComponentModel.DataAnnotations;

namespace AltinayStaj2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Text { get; set; }
        
    }

}
