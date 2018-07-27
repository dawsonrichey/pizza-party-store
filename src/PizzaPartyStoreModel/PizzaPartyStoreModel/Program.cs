using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaPartyStoreModel.Models;
using System.Data.Entity;

namespace PizzaPartyStoreModel
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new Context())
			{
				

				var pizzaParties = context.PizzaParties
					.Include(pp => pp.Pizza)
					.Include(pp => pp.Ingredients.Select(a => a.Ingredient))
					.Include(pp => pp.Ingredients.Select(a => a.Role))
					.ToList();

				foreach (var pizzaParty in pizzaParties)
				{
					var ingredientRoleNames = pizzaParty.Ingredients
						.Select(a => $"{a.Ingredient.Name} - {a.Role.Name}").ToList();
					var ingredientsRolesDisplayText = string.Join(", ", ingredientRoleNames);

					Console.WriteLine(pizzaParty.DisplayText);
					Console.WriteLine(ingredientsRolesDisplayText);
				}

				Console.ReadLine();
			}

		}
	}
}
