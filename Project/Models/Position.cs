﻿using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Position : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
