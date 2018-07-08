using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class Discounts
	{
		[Key]
		public int ClubMemberDiscounts { get; set; }
	}
}
