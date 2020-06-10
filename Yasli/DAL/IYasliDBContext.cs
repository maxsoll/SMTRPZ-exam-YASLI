using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public interface IYasliDBContext
    {
        DbSet<Child> Children { get; set; }
        DbSet<Parent> Parents { get; set; }
        DbSet<Group> Groups { get; set; }

        void OnModelCreating(ModelBuilder modelBuilder);
    }
}
