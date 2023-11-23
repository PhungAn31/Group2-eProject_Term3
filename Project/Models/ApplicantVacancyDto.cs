using Project.Data;

namespace Project.Models
{
    public class ApplicantVacancyDto
    {
        public string? ApplicantVacancy_Id { get; set; }

        public string? Vacancy_Id { get; set; }
        public Vacancy? Vacancy { get; set; }
        public int? Applicant_Id { get; set; }
        public Applicant? Applicant { get; set; }
        public int StatusApplicant_Id { get; set; }
        public StatusApplicant? StatusApplicant { get; set; }

    }
}
