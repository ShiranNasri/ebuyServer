using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
    public class ShipmentCompany
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ShipmentCompanyId { get; set; }
		public string CompanyName { get; set; }

		public virtual ICollection<ShipmentPrice> ShipmentPrices { get; set; }
	}
}
