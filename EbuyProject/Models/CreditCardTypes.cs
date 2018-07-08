using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class CreditCardTypes
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CardId { get; set; }
		public CreditCardType Type { get; set; }
		public int Prefix { get; set; }
        public int NumOfDigit { get; set; }

		public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
	}
}
