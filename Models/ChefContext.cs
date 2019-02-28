using Microsoft.EntityFrameworkCore;
 
namespace chefs_dishes.Models
{
    public class ChefContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public ChefContext(DbContextOptions<ChefContext> options) : base(options) { }
        public DbSet<Chef> chefs {get;set;}
        public DbSet<Dish> dishes {get;set;}
    }
}