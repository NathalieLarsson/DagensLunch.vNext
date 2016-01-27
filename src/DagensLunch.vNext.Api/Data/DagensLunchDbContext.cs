using System.Linq;
using DagensLunch.vNext.Api.Data.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace DagensLunch.vNext.Api.Data
{
    public class DagensLunchDbContext : DbContext
    {
		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<UserRestaurantRole> UserRestaurantRoles { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
			{
				relationship.DeleteBehavior = DeleteBehavior.Restrict;
			}

			base.OnModelCreating(builder);
		}
	}
}
