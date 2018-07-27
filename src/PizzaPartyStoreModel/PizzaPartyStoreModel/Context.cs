using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaPartyStoreModel.Models;

namespace PizzaPartyStoreModel
{
	public class Context : DbContext
	{
		public Context()
		{
			//Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
			//Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
			Database.SetInitializer(new DropCreateDatabaseAlways<Context>());

		}

		public DbSet<PizzaParty> PizzaParties { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			//modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
			//modelBuilder.Conventions.Add(new DecimalPropertyConvention(5, 2));

			modelBuilder.Entity<PizzaParty>()
				.Property(pp => pp.AverageRating)
				.HasPrecision(5, 2);
		}

	}
}
