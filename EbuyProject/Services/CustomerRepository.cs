using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EbuyProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EbuyProject.Services
{
	public class CustomerRepository : ICustomerRepository
	{
		private EbuyContext context;

		public CustomerRepository(EbuyContext context)
		{
			this.context = context;
		}

		public void AddCasualCustomer(CasualCustomer customer)
		{
			context.CasualCustomers.Add(customer);
			context.SaveChanges();
		}

		public void AddMemberCustomer(ClubMember customer)
		{
			var countries = GetCountries().ToList();
			var co = countries.Where(c => c.Country == customer.Country.Country).FirstOrDefault();
			co.ClubMembers.Add(customer);
			context.SaveChanges();
		}

		public void EditCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}

		public Customer GetCustomer(int customerId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ClubMember> GetClubMembers()
		{
			return context.ClubMembers.Include(c => c.Country).Include(c => c.Country.ShipmentArea);
		}

		public ClubMember GetClubMember(int id)
		{
			var member = context.ClubMembers.Include(cu => cu.Country).Include(c => c.Country.ShipmentArea).Where(c => c.MemberId == id).FirstOrDefault();
			return member;
		}

		public IEnumerable<CountryArea> GetCountries()
		{
			return context.CountryAreas.Include(c => c.ShipmentArea);
		}

		public IEnumerable<ShipmentArea> GetShipmentAreas()
		{
			return context.ShipmentAreas.Include(s=>s.ShipmentPrices);
		}
	}
}
