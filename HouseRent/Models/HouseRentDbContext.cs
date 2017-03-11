using System.Data.Entity;

namespace HouseRent.Models
{
    public class HouseRentDbContext : DbContext
    {
        public DbSet<RentInformation> RentInformations { get; set; }

    }
}