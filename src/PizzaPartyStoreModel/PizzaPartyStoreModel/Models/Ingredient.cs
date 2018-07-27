﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyStoreModel.Models
{
	public class Ingredient
	{
		public Ingredient()
		{
			PizzaParties = new List<PizzaPartyIngredient>();
		}
		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<PizzaPartyIngredient> PizzaParties { get; set; }

	}
}
