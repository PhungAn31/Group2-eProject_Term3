using Microsoft.AspNetCore.Identity;
using Project.Data;

namespace Project.Models
{
    public class InterviewVacancyDto
    {
        public int Id { get; set; }
        public int StatusInterview_Id { get; set; }
   
        public StatusInterview? StatusInterview { get; set; }

        public string? ApplicantVacancy_Id { get; set; }
      
        public ApplicantVacancy? ApplicantVacancy { get; set; }

        public string? Interview_Id { get; set; }
       
        public IdentityUser? IdentityUser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
