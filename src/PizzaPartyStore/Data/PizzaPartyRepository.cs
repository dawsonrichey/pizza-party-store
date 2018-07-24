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
				Id = 1,
				PizzaName = "Porky The Pie",
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
				Id = 2,
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
				Id = 3,
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

		public PizzaParty[] GetPizzaParties()
		{
			return _pizzaParties;
		}

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