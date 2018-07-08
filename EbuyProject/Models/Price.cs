using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EbuyProject.Models
{
	public class Price
	{
		[Key]
		public int ProductId { get; set; }
		public double ProductPrice { get; set; }

	}
}