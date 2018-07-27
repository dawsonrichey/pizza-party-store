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
				var pizza1 = new Pizza()
				{
					Name = "Wakin' Bacon"
				};
				var pizza2 = new Pizza()
				{
					Name = "Italian Stallion"
				};

				var ingredient1 = new Ingredient()
				{
					Name = "Sausage"
				};

				var ingredient2 = new Ingredient()
				{
					Name = "Cheese"
				};

				var ingredient3 = new Ingredient()
				{
					Name = "Sausage Gravy"
				};

				var role1 = new Role()
				{
					Name = "Meat"
				};
				var role2 = new Role()
				{
					Name = "Other"
				};

				var pizzaParty1 = new PizzaParty()
				{
					Pizza = pizza1,
					PizzaCost = 12,
					PublishedOn = DateTime.Today
				};
				pizzaParty1.AddIngredient(ingredient1, role1);
				pizzaParty1.AddIngredient(ingredient2, role2);

				var pizzaParty2 = new PizzaParty()
				{
					Pizza = pizza2,
					PizzaCost = 14,
					PublishedOn = DateTime.Today
				};
				pizzaParty2.AddIngredient(ingredient2, role1);
				pizzaParty2.AddIngredient(ingredient3, role2);

				var pizzaParty3 = new PizzaParty()
				{
					Pizza = pizza2,
					PizzaCost = 124,
					PublishedOn = DateTime.Today
				};
				pizzaParty3.AddIngredient(ingredient1, role1);
				pizzaParty3.AddIngredient(ingredient3, role2);

				context.PizzaParties.Add(pizzaParty1);
				context.PizzaParties.Add(pizzaParty2);
				context.PizzaParties.Add(pizzaParty3);

				context.SaveChanges();

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
