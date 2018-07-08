using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyProject.Models
{
	public class CasualCustomer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int CasualId { get; set; }
		//[ForeignKey("CustomerId")]
		//public virtual Customer Customer { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public DateTime FirstPurchase { get; set; }
	}
}