using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class ShipmentPrice
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ShipmentPriceId { get; set; }
		public double BasicCharge { get; set; }
		public double ItemCharge { get; set; }
		public int ShipmentDuration { get; set; }

		[ForeignKey("ShipmentAreaId")]
		public virtual ShipmentArea ShipmentArea { get; set; }

		[ForeignKey("ShipmentOptionId")]
		public virtual ShipmentOptions ShipmentOption { get; set; }

		[ForeignKey("ShipmentCompanyId")]	
		public virtual ShipmentCompany ShipmentCompany { get; set; }


	}
}
