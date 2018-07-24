using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaPartyStore.Data;
using PizzaPartyStore.Models;

namespace PizzaPartyStore.Controllers
{
	public class PizzaPartyController : Controller
	{
		private PizzaPartyRepository _pizzaPartyRepository = null;

		public PizzaPartyController()
		{
			_pizzaPartyRepository = new PizzaPartyRepository();
		}

		public ActionResult Index()
		{
			var pizzaParties = _pizzaPartyRepository.GetPizzaParties();

			return View(pizzaParties);
		}

		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}

			var pizzaParty = _pizzaPartyRepository.GetPizzaParty((int)id);
			 
			return View(pizzaParty);
		}
	}
}