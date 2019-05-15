using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BOTC
{

  public class BOTCContext : DbContext
  {
    public DbSet<Bandit> Bandit { get; set; }
    public DbSet<Classes> Classes{ get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<Weapon> Weapon { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=botc;user=root;password=root;port=8889;");
    }

  }

}
