using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
	public class EbuyContext : DbContext
	{
		public EbuyContext(DbContextOptions<EbuyContext> options)
			: base(options)
		{
			Database.Migrate();
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Bogo> Bogos { get; set; }
		public DbSet<CasualCustomer> CasualCustomers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ClubMember> ClubMembers { get; set; }
		public DbSet<Personnel> Personnels { get; set; }
		public DbSet<Price> Prices { get; set; }
		public DbSet<DeliveryModes> DeliveryModes { get; set; }
		public DbSet<PurchasedProduct> PurchasedProducts { get; set; }
		public DbSet<ShipmenDetails> ShipmenDetails { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<CreditCardTypes> CreditCardTypes { get; set; }
		public DbSet<Vat> Vat { get; set; }
		public DbSet<Discounts> Discounts { get; set; }
		public DbSet<ShipmentArea> ShipmentAreas { get; set; }
		public DbSet<CountryArea> CountryAreas { get; set; }
		public DbSet<ShipmentCompany> ShipmentCompanies { get; set; }
		public DbSet<ShipmentPrice> ShipmentPrices { get; set; }
		public DbSet<ShipmentOptions> ShipmentOptions { get; set; }
		public DbSet<Author> Authors { get; set; }


		public enum CreditCardType
		{
			Visa, Mastercard, AmericanExpress
		}
		public enum DeliveryMode
		{
			electronically, hard
		}
		public enum ShipmentOption
		{
			AirStandard, AirExpress, Boat
		}

		public enum UserType
		{
			Marketing, Financial, Administrator
		}

		public enum CategoryType
		{
			Book, Magazine, Newspaper, Article
		}

	}
}
