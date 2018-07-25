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

		public DbSet<PizzaParty> PizzaParties { get; set; }

	}
}
