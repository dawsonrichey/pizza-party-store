using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaPartyStoreModel.Models;

namespace PizzaPartyStoreModel
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new Context())
			{
				context.PizzaParties.Add(new PizzaParty()
				{
					PizzaName = "fart",
					PizzaCost = 1,
					PublishedOn = DateTime.Today
				});
				context.SaveChanges();

				var pizzaParties = context.PizzaParties.ToList();
				foreach (var pizzaParty in pizzaParties)
				{
					Console.WriteLine(pizzaParty.PizzaName);
				}

				Console.ReadLine();
			}

		}
	}
}
