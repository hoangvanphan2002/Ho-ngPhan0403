using HoangVanPhan0403.Models;
using Microsoft.EntityFrameworkCore;

namespace HoangVanPhan0403.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<SinhVien> SinhVien { get; set; }
    }
}    