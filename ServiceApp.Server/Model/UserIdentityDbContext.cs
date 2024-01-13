using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ServiceApp.Server.Model
{
    public class UserIdentityDbContext : IdentityDbContext
    {
        public UserIdentityDbContext(DbContextOptions<UserIdentityDbContext> options): base(options) 
        { 

        }

    }
}
