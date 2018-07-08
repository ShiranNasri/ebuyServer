using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyProject.Models
{
	public class Product
	{
		public Product()
		{
			this.PurchasedProducts = new HashSet<PurchasedProduct>();
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductId { get; set; }
		public string Title { get; set; }
		public DateTime PublicationDate { get; set; }
		public double Price { get; set; }
		public string ProductAbstract { get; set; }
		[ForeignKey("CategoryId")]
		public Category Category { get; set; }

		[ForeignKey("BogoId")]
		public Bogo Bogo { get; set; }

		[ForeignKey("AuthorId")]
		public Author Author { get; set; }

		public virtual ICollection<PurchasedProduct> PurchasedProducts { get; set; }
	}
}