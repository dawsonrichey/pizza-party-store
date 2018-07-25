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
		public Pizza Pizza { get; set; }
		public int PizzaCost { get; set; }
		public string Description { get; set; }
		public DateTime PublishedOn { get; set; }
		public decimal? AverageRating { get; set; }

		public string DisplayText
		{
			get
			{
				return $"{Pizza?.Name} ${PizzaCost}";
			}
		}
	}
}
