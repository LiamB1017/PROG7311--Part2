using Microsoft.AspNetCore.Identity;
namespace PROG7311_Part2.Models
{


    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}

