
using Microsoft.EntityFrameworkCore;
using AltinayStaj2.Models;
using System;
using System.Linq;
using AltinayStaj2;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }

    public DbSet<SaveData> SaveDatas { get; set; }

    public DbSet<CurrentData> CurrentDatas { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-CMU4MOP\\SQLEXPRESS;Initial Catalog=AltinayDb;Integrated Security=True;Persist Security Info=true;TrustServerCertificate=true;");
    }
}
