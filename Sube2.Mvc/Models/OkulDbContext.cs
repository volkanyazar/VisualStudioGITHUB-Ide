using Microsoft.EntityFrameworkCore;

namespace Sube2.Mvc.Models
{
    public class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OkulDbMvcSube2;Integrated Security=true;Uid=sa;Password=12345;");
        }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");
            
            modelBuilder.Entity<Ogrenci>().Property(o=>o.Ad).HasColumnType("varchar").HasMaxLength(25).IsRequired();

            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            modelBuilder.Entity<Ogrenci>().HasIndex(o => o.Numara).IsUnique();
        }
    }
}
