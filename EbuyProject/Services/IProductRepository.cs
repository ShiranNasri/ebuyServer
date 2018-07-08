using EbuyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Services
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetProducts();
		IEnumerable<Product> GetProductsByQuery(Query query);
		IEnumerable<Author> GetAuthors();
		IEnumerable<DeliveryModes> GetDeliveryModes();
		Product GetProduct(int productId);
		void CreateTransaction(Transaction transaction);
	}
}
