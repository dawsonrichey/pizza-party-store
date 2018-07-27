using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyStoreModel.Models
{
	public class PizzaParty
	{
		public PizzaParty()
		{
			Ingredients = new List<PizzaPartyIngredient>();
		}

		//ID, PizzaPartsId, PizzaPartyID
		public int Id { get; set; }
		public int PizzaId { get; set; }
		public int PizzaCost { get; set; }
		public string Description { get; set; }
		public DateTime PublishedOn { get; set; }
		public decimal? AverageRating { get; set; }

		public Pizza Pizza { get; set; }
		public ICollection<PizzaPartyIngredient> Ingredients { get; set; }

		public string DisplayText
		{
			get
			{
				return $"{Pizza?.Name} ${PizzaCost}";
			}
		}

		public void AddIngredient(Ingredient ingredient, Role role)
		{
			Ingredients.Add(new PizzaPartyIngredient()
			{
				Ingredient = ingredient,
				Role = role
			});
		}
	}
}
