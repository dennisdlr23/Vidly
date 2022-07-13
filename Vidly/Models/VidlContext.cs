using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Vidly.Models
{

    public class VidlContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Rental> Rentals { get; set; }


        public VidlContext()
           : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static VidlContext Create()
        {
            return new VidlContext();
        }

    }
}