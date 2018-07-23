using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaPartyStore.Models;

namespace PizzaPartyStore.Data
{
	public class PizzaPartyRepository
	{
		private static PizzaParty[] _pizzaParties = new PizzaParty[]
			{
				new PizzaParty()
			{
				PizzaName = "Porky-the-pie",
				PizzaCost = 11,
				DescriptionHtml = "<p>Traditional Crust, Red Sauce, Cheese, Pepperoni, Bacon, Ham and Sausage.</p>",
				Toppings = new Topping[]
				{
					new Topping() {Name = "Bacon", Role = "Meat" },
					new Topping() {Name = "Sausage", Role = "Meat" },
					new Topping() {Name = "Mushroom", Role = "Vegetable" }
				},
				Favorite = false
			},
				new PizzaParty()
			{
				PizzaName = "Italian Stallion",
				PizzaCost = 14,
				DescriptionHtml = "<p>Traditional Crust, Red Sauce, Cheese, Italian Sausage, Pepperoni, Mushroom and Wisconsin Cheddar.</p>",
				Toppings = new Topping[]
				{
					new Topping() {Name = "Bacon", Role = "Meat" },
					new Topping() {Name = "Wisconson Cheddar", Role = "Cheese" },
					new Topping() {Name = "Mushroom", Role = "Vegetable" }
				},
				Favorite = false
			},
								new PizzaParty()
			{
				PizzaName = "Wakin' Bacon",
				PizzaCost = 12,
				DescriptionHtml = "<p>Traditional Crust, Sausage Gravy, Bacon, Mozzarella and Cheddar Cheese. The taste of buiscuts and gravy!",
				Toppings = new Topping[]
				{
					new Topping() {Name = "Bacon", Role = "Meat" },
					new Topping() {Name = "Wisconson Cheddar", Role = "Cheese" },
					new Topping() {Name = "Sausage Gravy", Role = "Other" }
				},
				Favorite = false
			}


			};

		public PizzaParty GetPizzaParty(int id)
		{
			PizzaParty pizzaPartyToReturn = null;

			foreach (var pizzaParty in _pizzaParties)
			{
				if (pizzaParty.Id == id)
				{
					pizzaPartyToReturn = pizzaParty;

					break;
				}
			}

			return pizzaPartyToReturn;
		}
	}
}