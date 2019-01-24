using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace recipes_book.Models
{
    public class RecipesBookContext : DbContext
    {
        public RecipesBookContext() : base("RecipesBookContext")
        {
            Database.SetInitializer<RecipesBookContext>(new CreateDatabaseIfNotExists<RecipesBookContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}