using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaPartyStore.Controllers
{
	public class PizzaPartyController : Controller
	{
		public ActionResult Detail()
		{
			ViewBag.PizzaName = "Porky-the-pie";
			ViewBag.PizzaCost = 11.99;
			ViewBag.Description = "<p>sdfdsfsdsdfsd</p>";
			ViewBag.Toppings = new string[]
			{
				"Meat: Bacon",
				"Meat: Sausage",
				"Vegetable: Mushroom"
			};

			return View();
		}
	}
}