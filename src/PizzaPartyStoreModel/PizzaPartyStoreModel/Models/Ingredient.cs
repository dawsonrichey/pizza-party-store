using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyStoreModel.Models
{
	public class Ingredient
	{
		public Ingredient()
		{
			PizzaParties = new List<PizzaPartyIngredient>();
		}
		public int Id { get; set; }
		[Required, StringLength(100)]
		public string Name { get; set; }


		public ICollection<PizzaPartyIngredient> PizzaParties { get; set; }

	}
}
