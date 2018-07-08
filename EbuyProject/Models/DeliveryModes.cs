using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class DeliveryModes
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ModeId { get; set; }
		[JsonConverter(typeof(StringEnumConverter))]
		public DeliveryMode Mode { get; set; }

		public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
	}
}
