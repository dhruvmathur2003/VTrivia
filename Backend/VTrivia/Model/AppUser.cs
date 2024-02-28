using Microsoft.AspNetCore.Identity;

namespace VTrivia.Model
{
    public class AppUser : IdentityUser
    {
        public string? Name {  get; set; }

    }
}
