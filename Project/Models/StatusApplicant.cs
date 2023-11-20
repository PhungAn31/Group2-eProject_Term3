using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class StatusApplicant : BaseEntity
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
    }
}
