using EbuyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Services
{
	interface ICustomerRepository
	{
		IEnumerable<ClubMember> GetClubMembers();
		ClubMember GetClubMember(int id);
		Customer GetCustomer(int customerId);
		void AddMemberCustomer(ClubMember customer);
		void AddCasualCustomer(CasualCustomer customer);
		void EditCustomer(Customer customer);
		IEnumerable<CountryArea> GetCountries();
		IEnumerable<ShipmentArea> GetShipmentAreas();
	}
}
