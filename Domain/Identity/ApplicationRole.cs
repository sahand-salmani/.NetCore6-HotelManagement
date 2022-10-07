using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    // override IdentityRole with ApplicationRole
    public class ApplicationRole : IdentityRole<string>
    {
        public ICollection<ApplicationUserRole> Users { get; set; }
    }
}
