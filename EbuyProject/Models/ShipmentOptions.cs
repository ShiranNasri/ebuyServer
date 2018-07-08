using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class ShipmentOptions
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ShipmentOptionId { get; set; }
		public ShipmentOption ShipmentOption { get; set; }

		public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

		public virtual ICollection<ShipmentPrice> ShipmentPrices { get; set; } = new List<ShipmentPrice>();
	}
}
