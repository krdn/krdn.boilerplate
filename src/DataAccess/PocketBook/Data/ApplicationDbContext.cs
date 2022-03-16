using Microsoft.EntityFrameworkCore;
using PocketBook.Models;

namespace PocketBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        // virtual을 사용하는 이유: https://quick-adviser.com/what-is-the-use-of-virtual-property/
        // Lazy loading, Test를 위해 사용한다고 되어 있는데 정확한 이유는 모름.
        // 최신 셈플에서는 virtual 키워드를 사용하고 있지 않음.
        // https://docs.microsoft.com/ko-kr/aspnet/core/data/ef-mvc/intro?view=aspnetcore-6.0#create-the-database-context
        public virtual DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
 