using Blazorit.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blazorit.Server.Data {
    public partial class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }

        public virtual DbSet<User> Users { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>(entity => {
                entity.Property(e => e.DateCreated).HasColumnType("timestamp without time zone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}