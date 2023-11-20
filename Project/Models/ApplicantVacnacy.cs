using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class ApplicantVacnacy : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Employee_Id { get; set; }
        [ForeignKey("Employee_Id")]
        [ValidateNever]
        public IdentityUser? IdentityUser { get; set; }

        public int StatusInterview_Id { get; set; }
        [ForeignKey("StatusInterview_Id")]
        [ValidateNever]
        public StatusInterview? StatusInterview { get; set; }
        public string? Vacancy_Id { get; set; }
        [ForeignKey("Vacancy_Id")]
        [ValidateNever]
        public Vacancy? Vacancy { get; set; }

        public string? Applicant_Id { get; set; }
        [ForeignKey("Applicant_Id")]
        [ValidateNever]
        public Applicant? Applicant { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
