using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolkanAppEntityFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    [Table("tblOgrenciler")]
    class Ogrenci
    {
        public int OgrenciId { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(25)]
        public string Ad { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(35)]
        public string Soyad { get; set; }
    }

    class OkulContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=VolkanAppEntityFrameWork;Integrated Security=true");
        }

    }

    

}
