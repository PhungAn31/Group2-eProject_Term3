using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class InterviewVacancy : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int StatusInterview_Id { get; set; }
        [ForeignKey("StatusInterview_Id")]
        [ValidateNever]
        public StatusInterview? StatusInterview { get; set; }

        public string? ApplicantVacancy_Id { get; set; }
        [ForeignKey("ApplicantVacancy_Id")]
        [ValidateNever]
        public ApplicantVacancy? ApplicantVacancy { get; set; }

      
        public string? Hr_id { get; set; }   
        public string? Interview_id { get; set; }    
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
