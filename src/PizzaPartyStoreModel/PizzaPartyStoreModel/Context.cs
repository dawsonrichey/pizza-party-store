using System;
using System.Collections.Generic;
using System.Data.Entity;
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

	}
}
