using System.ComponentModel.DataAnnotations;

namespace AGIRA_INTERVIEW_BACKEND.Models
{
    public enum UserRole
    {
        SuperAdmin,
        HR,
        Interviewer,
   
    }
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string EmployeeId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public UserRole Role { get; set; }

        public bool IsDeleted { get; set; }
    }
}
