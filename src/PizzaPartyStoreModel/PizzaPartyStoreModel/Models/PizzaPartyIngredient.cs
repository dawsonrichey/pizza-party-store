using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyStoreModel.Models
{
	public class PizzaPartyIngredient
	{
		public int Id { get; set; }
		public int PizzaPartyId { get; set; }
		public int IngredientId { get; set; }
		public int RoleId { get; set; }

		public PizzaParty PizzaParty { get; set; }
		public Ingredient Ingredient { get; set; }
		public Role Role { get; set; }

	}
}
