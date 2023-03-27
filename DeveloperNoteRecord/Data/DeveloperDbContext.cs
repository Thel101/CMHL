using System;
using DeveloperNoteRecord.Models;
using Microsoft.EntityFrameworkCore;

namespace DeveloperNoteRecord.Data
{
	public class DeveloperDbContext : DbContext
	{
		public DeveloperDbContext(DbContextOptions<DeveloperDbContext> options)
			: base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<DeveloperSkill>().HasKey(ds => new { ds.DeveloperId, ds.SkillSetId });
        }
        public DbSet<Developer> Developer { get; set; }
		public DbSet<Notes> Notes { get; set; }
		public DbSet<SkillSet> SkillSet { get; set; }
	}
}

