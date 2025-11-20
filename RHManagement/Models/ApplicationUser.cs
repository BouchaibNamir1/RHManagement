using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RHManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;
    }
}
