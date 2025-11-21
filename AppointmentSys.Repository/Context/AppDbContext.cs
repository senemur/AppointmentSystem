using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// AppointmentSys.Repository/Context/AppDbContext.cs
using AppointmentSys.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppointmentSys.Repository.Context
{
    public class AppDbContext : DbContext
    {
        // Constructor: Veritabanı ayarlarını API'den alabilmek için
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Tablolarım
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        // Veritabanı oluşurken çalışacak ayarlar
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API konfigürasyonları buraya yazılır.
            // Şimdilik boş bırakabilir veya temel ayarları yapabiliriz.

            base.OnModelCreating(modelBuilder);
        }
    }
}
