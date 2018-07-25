using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyStoreModel.Models
{
	public class Pizza
	{
		public Pizza()
		{
			PizzaParties = new List<PizzaParty>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public ICollection<PizzaParty> PizzaParties { get; set; }
	}
}
