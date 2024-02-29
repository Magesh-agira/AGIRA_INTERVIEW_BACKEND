using System.ComponentModel.DataAnnotations;

namespace AGIRA_INTERVIEW_BACKEND.Models
{
    public class Opportunities
    {
        public enum OpportunityStatus
        {
            Open,
            Closed,
            Hold
        }

        [Key]
        public int OpportunityId { get; set; }

        [Required]
        public string Position { get; set; }

        public string Location { get; set; }

        public string TypeOfEmployment { get; set; }

        public string Qualification { get; set; }

        public decimal Salary { get; set; } //done commiting

        [Required]
        public DateTime DatePosted { get; set; }

        [Required]
        public int NumberOfOpenings { get; set; }

        public string Requirements { get; set; }

        [Required]
        public OpportunityStatus Status { get; set; }
    }
}

