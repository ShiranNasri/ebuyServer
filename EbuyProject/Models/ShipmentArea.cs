using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class ShipmentArea
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ShipmentAreaId { get; set; }
		public string Area { get; set; }

		public virtual ICollection<CountryArea> CountryAreas { get; set; }
		public virtual ICollection<ShipmentPrice> ShipmentPrices { get; set; }

	}
}
