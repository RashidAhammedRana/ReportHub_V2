using Microsoft.AspNetCore.Identity;

namespace ReportHub_V2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Company { get; set; }
    }
}