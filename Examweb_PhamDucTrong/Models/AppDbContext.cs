using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examweb_PhamDucTrong.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<DiaNhac> DiaNhacs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaNhac>().HasData(
           new DiaNhac { Id=1, TuaCD = "CD Bản tình ca trong đêm", NgheSi = "Dương Thanh Nam", TrongNuoc = true, GiaBan = 250000, SoLuong = 20 },
            new DiaNhac { Id = 2, TuaCD = "CD Nổi buồn gác trọ", NgheSi = "Võ Văn Dương", TrongNuoc = true, GiaBan = 105000, SoLuong = 15 },
             new DiaNhac { Id = 3, TuaCD = "CD Today's US-UK Hit", NgheSi = "The Weekend", TrongNuoc = false, GiaBan = 500000, SoLuong = 30 },
              new DiaNhac { Id = 4, TuaCD = "CD Chuyện chúng mình", NgheSi = "Phương Mỹ Chi", TrongNuoc = true, GiaBan = 150000, SoLuong = 20 },
          new DiaNhac { Id = 5, TuaCD = "CD BabyMonster", NgheSi = "WonYoung", TrongNuoc = false, GiaBan = 400000, SoLuong = 50 });
        }
    }
}
