using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyProject.Models
{
	public class ShipmenDetails
	{
		public ShipmenDetails()
		{
			this.Transactions = new HashSet<Transaction>();
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ShipmenDetailsId{ get; set; }
		public string Buyer { get; set; }
		public string Country { get; set; }
		public string State { get; set; }
		public int ZipCode { get; set; }
		public string Street { get; set; }
		public int HouseNumber { get; set; }
		public int Pob { get; set; } //Post Office Box
		public string Email { get; set; }

		public virtual ICollection<Transaction> Transactions { get; set; }

	}
}