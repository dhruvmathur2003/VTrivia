using Microsoft.AspNetCore.Identity;

namespace VTrivia.Model
{
    public class AppUser : IdentityUser
    {
        public string? Name {  get; set; }
        public List<Group>? groups { get; set; }

        public AppUser() { 
            groups = new List<Group>();
        }
    }
}
