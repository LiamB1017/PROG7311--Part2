using Microsoft.AspNetCore.Identity;
using PROG7311_Part2.Models;

namespace PROG7311_Part2.Data
{
    public static class DbInitializer
    {
        public static async Task SeedRolesAndAdmin(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string[] roles = { "Farmer", "Employee" };

            foreach (var role in roles) ;
                
               

            
        }
    }
}

