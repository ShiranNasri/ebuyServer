  using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyProject.Models
{
	public class ClubMember
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int MemberId { get; set; }
		//[ForeignKey("CustomerId")]
		//public virtual Customer Customer { get; set; }
		public string LoginName { get; set; }
		public string Password { get; set; }
		[ForeignKey("CountryId")]
		public CountryArea Country { get; set; }
		public string City { get; set; }
		public int HouseNumber { get; set; }
		public string Street { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public DateTime FirstRegistration { get; set; }
	}
}