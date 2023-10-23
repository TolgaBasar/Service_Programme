﻿using System.ComponentModel.DataAnnotations;

namespace AltinayStaj2
{
    public class CurrentData
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Text { get; set; }
        public string? NumberPlate { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
