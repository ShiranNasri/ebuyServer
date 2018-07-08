using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyProject.Models
{
	public class PurchasedProduct
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PurchaseProductId { get; set; }
		public DateTime PurchasedDate { get; set; }
		public double PurchaseBasicCost { get; set; }
		public double Vat { get; set; } //Value Added Tax

		public int CustomerId { get; set; }
		//public virtual Customer Customer { get; set; }

		public int TransactionId { get; set; }
		[ForeignKey("TransactionId")]
		public Transaction Transaction { get; set; }

		public int ProductId { get; set; }
		public virtual Product Products { get; set; }
	}
}