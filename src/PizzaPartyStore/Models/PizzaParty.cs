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

		public string DisplayText
		{
			get
			{
				return PizzaName + " $" + PizzaCost;
			}
		}
		// series-title-issuenumber.jpg
		public string CoverImageFileName
		{
			get
			{
				return PizzaName.Replace(" ", "-")
					.ToLower() + "-" + PizzaCost + ".jpg";
			}
		}
	}
}