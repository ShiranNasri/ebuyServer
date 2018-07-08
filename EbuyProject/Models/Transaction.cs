using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyProject.Models
{
	public class Transaction
	{
		[Key]
		public int TransactionId { get; set; }
		//public CreditCardType CreditCardType { get; set; }
		public int CreditCardNumber { get; set; }
		[ForeignKey("ModeId")]
		public DeliveryModes DeliveryMode { get; set; }
		public DateTime DeliveryDate { get; set; }
		//public ShipmentOption ShipmentOption { get; set; }
		public double ShipmentCost { get; set; }
		//public double TotalCost { get; set; }
		//public int CardNumber { get; set; }
		public string CardExpire { get; set; }
		public string CardOwner { get; set; }
		public double TotalCost { get; set; }

		[ForeignKey("ShipmentDetailsId")]
		public virtual ShipmenDetails ShipmenDetails { get; set; }

		[ForeignKey("ShipmentOptionId")]
		public virtual ShipmentOptions ShipmentOptions { get; set; }

		[ForeignKey("CardId")]
		public virtual CreditCardTypes CreditCardTypes { get; set; }

		public virtual ICollection<PurchasedProduct> Product { get; set; }
	}

	public enum CreditCardType
	{
		Visa, Mastercard, AmericanExpress
	}
	public enum DeliveryMode
	{
		electronically, hard
	}
	public enum ShipmentOption
	{
		AirStandard, AirExpress, Boat
	}
}