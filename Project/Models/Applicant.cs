using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Applicant : BaseEntity
    {
        [Key]
        public string? Applicant_Id { get; set; }
        public int? User_Id  { get; set; }
        [ForeignKey("User_Id")]
        [ValidateNever]
        public User? User { get; set; }

        public int StatusApplicant_Id  { get; set; }
        [ForeignKey("StatusApplicant_Id")]
        [ValidateNever]
        public StatusApplicant? StatusApplicant { get; set; }
    }
}
