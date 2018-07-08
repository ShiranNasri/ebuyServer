using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class CountryArea
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CountryId { get; set; }
		public string Country { get; set; }

		[ForeignKey("ShipmentAreaId")]
		public ShipmentArea ShipmentArea { get; set; }

		public ICollection<ClubMember> ClubMembers { get; set; } = new List<ClubMember>();

	}
}
