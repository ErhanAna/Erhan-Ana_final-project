using Microsoft.EntityFrameworkCore;
using Erhan_Ana_Maria_proiect_final.Models;

namespace Erhan_Ana_Maria_proiect_final.Data
{
    public class RecordStoreContext:DbContext
    {
        public RecordStoreContext(DbContextOptions<RecordStoreContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<ReleasedAlbum> ReleasedAlbums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Album>().ToTable("Album");
            modelBuilder.Entity<Label>().ToTable("Label");
            modelBuilder.Entity<ReleasedAlbum>().ToTable("ReleasedAlbum");

            modelBuilder.Entity<ReleasedAlbum>()
                .HasKey(c => new { c.AlbumID, c.LabelID });
        }
    }
}
