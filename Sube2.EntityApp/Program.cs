using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Sube2.EntityApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var ogr = new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet" };

            //using (var ctx=new OkulContext())
            //{
            //    ctx.Ogrenciler.Add(ogr);
            //    ctx.SaveChanges();
            //}

            //using (var ctx = new OkulContext())
            //{
            //    var ogrenci = ctx.Ogrenciler.Find(2);
            //    ogrenci.Soyad = "Uslu";
            //    ctx.Entry(ogrenci).State = EntityState.Modified;
            //    ctx.SaveChanges();
            //}

            //using (var ctx = new OkulContext())
            //{
            //    var ogrenci = ctx.Ogrenciler.Find(2);
            //    ctx.Ogrenciler.Remove(ogrenci);
            //    ctx.SaveChanges();
            //}

            //Linq: Language Integrated Query

            //using (var ctx = new OkulContext())
            //{
            //    List<Ogrenci> lst = ctx.Ogrenciler.ToList();
            //    foreach (var o in lst)
            //    {
            //        Console.WriteLine(o.ToString());
            //    }
            //}
            //OgrenciEkle View'i oluşturalım
            //Ogrenci bilgilerini kullanıcıdan almak için form oluşturalım
            //Kaydet butonu ile kullanıcıdan alınan veriler, db'ye eklenecek.

            //Mvc ModelBinder

            //Github
        }
    }

    [Table("tblOgrenciler")]
    class Ogrenci
    {
        public int Ogrenciid { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(25)]
        public string Ad { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(35)]
        public string Soyad { get; set; }

        public override string ToString()
        {
            return $"OgrenciId:{this.Ogrenciid}\nAdı:{this.Ad}\nSoyad:{this.Soyad}";
        }
    }


    class Ders
    {
        public int Dersid { get; set; }
        public string Dersad { get; set; }
        public int Kontenjan { get; set; }
    }

    class OkulContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OkulAppDbSube2;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>().ToTable("tblDersler");
            modelBuilder.Entity<Ders>().Property(p => p.Dersad).HasColumnType("varchar").HasMaxLength(30).IsRequired();

        }//Fluent Api
    }
}
