using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    // override IdentityUser with ApplicationUser
    public class ApplicationUser : IdentityUser<string>
    {
        public ICollection<ApplicationUserRole> Roles { get; set; }
    }
    
}
