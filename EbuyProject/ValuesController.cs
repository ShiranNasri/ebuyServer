using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using EbuyProject.Models;
using EbuyProject.Services;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EbuyProject
{
	[Route("api/[controller]/[action]")]
	[EnableCors("AllowSpecificOrigin")]
	public class ValuesController : Controller
	{
		private EbuyContext context;
		private ProductRepository _rep;
		public ValuesController(EbuyContext context)
		{
			this.context = context;
			this._rep = new ProductRepository(this.context);
		}

		// GET: api/values
		[HttpGet]
		[ActionName("GetProducts")]
		public IEnumerable<Product> Get()
		{
			return _rep.GetProducts();

		}

		[HttpGet]
		[ActionName("GetAuthors")]
		public IEnumerable<Author> GetAuthors()
		{
			return _rep.GetAuthors();

		}
		[HttpGet]
		[ActionName("GetDeliveryModes")]
		public IEnumerable<DeliveryModes> GetDeliveryModes()
		{
			return _rep.GetDeliveryModes();

		}

        [HttpGet]
        [ActionName("GetShipmentPrices")]
        public object GetShipmentPrices()
        {
              return _rep.GetShipmentPrices();

        }

        [HttpGet("{title}/{author}/{keywords}/{specificDate}/{startDate}/{endDate}/{isSpecifiedChecked}")]
		[ActionName("GetProductsByQuery")]
		public IEnumerable<Product> GetProductsByQuery(string title, string author, string keywords,
			DateTime specificDate, DateTime startDate, DateTime endDate, bool isSpecifiedChecked)
		{
			return _rep.GetProductsByQuery(new Query()
			{
				Title = title,
				Author = author,
				Keywords = keywords,
				SpecificDate = specificDate,
				StartDate = startDate,
				EndDate = endDate,
				IsSpecifiedChecked = isSpecifiedChecked
			});
		}

		[HttpGet("{title}")]
		[ActionName("GetProductsByQuery")]
		public IEnumerable<Product> GetProductsByQuery(string title)
		{
			return _rep.GetProductsByQuery(title);
		}

		//[HttpPost("{creditCardType}/{deliveryMode}/{deliveryDate}/{shipmentOption}/{shipmentCost}/{totalCost}/{cardNumber}/{cardExpire}/{cardOwner}")]
		[HttpPost]
		[ActionName("CreateTransaction")]
		public void CreateTransaction([FromBody]object transaction)
		{
			var transactionString = transaction.ToString();
			var trans = JsonConvert.DeserializeObject<Transaction>(transactionString);
			_rep.CreateTransaction(trans);
		}


		// GET api/values/5
		//[HttpGet("{id}")]
		//public string Get(int id)
		//{
		//    return "value";
		//}

		//// POST api/values
		//[HttpPost]
		//public void Post([FromBody]string value)
		//{
		//}

		//// PUT api/values/5
		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody]string value)
		//{
		//}

		//// DELETE api/values/5
		//[HttpDelete("{id}")]
		//public void Delete(int id)
		//{
		//}
	}
}
