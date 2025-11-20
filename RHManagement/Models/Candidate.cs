using System;
using System.ComponentModel.DataAnnotations;

namespace RHManagement.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom complet est obligatoire")]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'email est obligatoire")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [StringLength(255)]
        public string ResumeUrl { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
    }
}
