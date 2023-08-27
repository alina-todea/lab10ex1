using System;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using lab10ex1;

namespace lab10ex1.Models

{
	internal class UniversityDbContext : DbContext

	{
		public DbSet<Student> Students { get; set; }

        public UniversityDbContext()
		{
			Database.EnsureCreated();
		}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=postgres;Database='cursdotnetlab10ex1'");

    }
}

