using Microsoft.AspNet.Identity.EntityFramework;
using RD.Entities;
using System;

namespace RacerDomo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public Location Location { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}