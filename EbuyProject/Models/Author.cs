using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class Author
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int AuthorId { get; set; }
		public string AuthorName { get; set; }
		virtual public ICollection<Product> Products { get; set; } = new List<Product>();
	}
}
