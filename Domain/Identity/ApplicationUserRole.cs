using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    // override the ApplicationUserRole with identityUserRole
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
