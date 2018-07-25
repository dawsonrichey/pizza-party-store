using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyStoreModel.Models
{
	public class PizzaParty
	{
		//ID, PizzaPartsId, PizzaPartyID
		public int Id { get; set; }
		public string PizzaName { get; set; }
		public int PizzaCost { get; set; }
		public string Description { get; set; }
		public DateTime PublishedOn { get; set; }
		public decimal? AverageRating { get; set; }

	}
}
