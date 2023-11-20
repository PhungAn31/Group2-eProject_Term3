using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class StatusInterview : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
