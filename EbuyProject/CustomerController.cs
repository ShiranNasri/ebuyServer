using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EbuyProject.Models;
using EbuyProject.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EbuyProject
{
	[Route("api/[controller]/[action]")]
	[EnableCors("AllowSpecificOrigin")]
	public class CustomerController : Controller
	{
		private EbuyContext context;
		private CustomerRepository _rep;

		public CustomerController(EbuyContext context)
		{
			this.context = context;
			_rep = new CustomerRepository(context);
		}
		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<ClubMember> GetClubMembers()
		{
			var clubMembers = _rep.GetClubMembers();
			return clubMembers;
		}

		[HttpGet]
		public IEnumerable<CountryArea> GetCountries()
		{
			var countries = _rep.GetCountries();
			return countries;
		}

		[HttpGet]
		public IEnumerable<ShipmentArea> GetShipmentAreas()
		{
			var areas = _rep.GetShipmentAreas();
			return areas;
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		[ActionName("GetClubMember")]
		public ClubMember GetClubMember(int id)
		{
			return _rep.GetClubMember(id);
		}

		// POST api/<controller>
		[HttpPost]
		public void PostClubMember([FromBody]object Member)
		{
			var clubMemberString = Member.ToString();
			//var customerId = JsonConvert.DeserializeObject<Customer>(clubMemberString).CustomerId;
			var clubMember = JsonConvert.DeserializeObject<ClubMember>(clubMemberString);
			_rep.AddMemberCustomer(clubMember);

		}

		[HttpPost]
		public void AddCasualCustomer([FromBody] object Casual)
		{
			var casualString = Casual.ToString();
			//var customerId = JsonConvert.DeserializeObject<Customer>(casualString).CustomerId;
			var casual = JsonConvert.DeserializeObject<CasualCustomer>(casualString);
			_rep.AddCasualCustomer(casual);
		}

		// PUT api/<controller>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
