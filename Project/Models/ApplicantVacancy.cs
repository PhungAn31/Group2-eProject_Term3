using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class ApplicantVacancy : BaseEntity
    {
        [Key]
        public string? ApplicantVacancy_Id { get; set; }

        public string? Vacancy_Id { get; set; }
        [ForeignKey("Vacancy_Id")]
        [ValidateNever]
        public Vacancy? Vacancy { get; set; }
        public int? Applicant_Id  { get; set; }
        [ForeignKey("Applicant_Id")]
        [ValidateNever]
        public Applicant? Applicant { get; set; }
        public int StatusApplicant_Id  { get; set; }
        [ForeignKey("StatusApplicant_Id")]
        [ValidateNever]
        public StatusApplicant? StatusApplicant { get; set; }
    }
}
