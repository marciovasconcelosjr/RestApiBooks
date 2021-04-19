﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        } 
        
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}
