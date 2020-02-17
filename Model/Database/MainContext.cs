using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Database
{
    public class MainContext : DbContext
    {

        public MainContext(DbContextOptions<MainContext> options)
           : base(options)
        { }

        public DbSet<Company> Company { get; set; }
    }
}
