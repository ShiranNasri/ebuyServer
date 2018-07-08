using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EbuyProject.Models
{
	public class Bogo
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int BogoId { get; set; }
		public int BogoLevel { get; set; }
		virtual public ICollection<Product> Products { get; set; }
	}
}