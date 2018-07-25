using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyStoreModel.Models
{
	public class Ingredient
	{
		public Ingredient()
		{
			PizzaParties = new List<PizzaParty>();
		}
		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<PizzaParty> PizzaParties { get; set; }

	}
}
