using Microsoft.AspNetCore.Identity;

namespace ZombieParty.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string NickName { get; set; }
    }

}
