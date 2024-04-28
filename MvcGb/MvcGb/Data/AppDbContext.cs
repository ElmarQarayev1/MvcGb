using System;
using Microsoft.EntityFrameworkCore;
using MvcGb.Models;

namespace MvcGb.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}

		public DbSet<Project> Projects { get; set; }

		public DbSet<Category> Categories { get; set;}

		public DbSet<ProjectImage> ProjectImages { get; set; }
	}
}

