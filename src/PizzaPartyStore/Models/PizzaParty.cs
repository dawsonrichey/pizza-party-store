using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaPartyStore.Models
{
	public class PizzaParty
	{
		public int Id { get; set; }
		public string PizzaName { get; set; }
		public int PizzaCost { get; set; }
		public string DescriptionHtml { get; set; }
		public Topping[] Toppings { get; set; }
		public bool Favorite { get; set; }
	}
}