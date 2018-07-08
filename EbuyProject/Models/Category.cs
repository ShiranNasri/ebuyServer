using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyProject.Models
{
	public class Category
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int CategoryId { get; set; }
		public CategoryType CategoryType { get; set; }

		virtual public ICollection<Product> Products { get; set; } = new List<Product>();
	}

	public enum CategoryType
	{
		Book=1, Magazine=2, Newspaper=3, Article=4
	}
}