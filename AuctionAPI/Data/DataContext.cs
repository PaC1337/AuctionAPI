using Microsoft.EntityFrameworkCore;

namespace AuctionAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Auction> Auctions { get; set; }
        
    }
}
