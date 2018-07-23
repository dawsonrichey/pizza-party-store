using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaPartyStore.Models;

namespace PizzaPartyStore.Controllers
{
	public class PizzaPartyController : Controller
	{
		public ActionResult Detail()
		{
			var pizzaParty = new PizzaParty()
			{
				PizzaName = "Porky-the-pie",
				PizzaCost = 11,
				DescriptionHtml = "<p>sdfdsfsdsdfsd </p>",
				Toppings = new Topping[]
				{
					new Topping() {Name = "Bacon", Role = "Meat" },
					new Topping() {Name = "Sausage", Role = "Meat" },
					new Topping() {Name = "Mushroom", Role = "Vegetable" },
				}
			};
			 
			return View(pizzaParty);
		}
	}
}