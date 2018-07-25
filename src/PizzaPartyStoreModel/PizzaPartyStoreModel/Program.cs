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
				var pizza = new Pizza()
				{
					Name = "Wakin' Bacon"
				};
				context.PizzaParties.Add(new PizzaParty()
				{
					Pizza = pizza,
					PizzaCost = 12,
					PublishedOn = DateTime.Today
				});
				context.PizzaParties.Add(new PizzaParty()
				{
					Pizza = pizza,
					PizzaCost = 14,
					PublishedOn = DateTime.Today
				});

				context.SaveChanges();

				var pizzaParties = context.PizzaParties
					.Include(pp => pp.Pizza)
					.ToList();

				foreach (var pizzaParty in pizzaParties)
				{
					Console.WriteLine(pizzaParty.DisplayText);
				}

				Console.ReadLine();
			}

		}
	}
}
