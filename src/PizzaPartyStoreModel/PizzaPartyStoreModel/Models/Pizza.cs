using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
		[Required, StringLength(200)]
		public string Name { get; set; }
		public string Description { get; set; }

		public ICollection<PizzaParty> PizzaParties { get; set; }
	}
}
