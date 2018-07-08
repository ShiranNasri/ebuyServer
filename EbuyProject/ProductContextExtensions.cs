using EbuyProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject
{
	public static class ProductContextExtensions
	{
		public static void EnsureSeedDataForContext(this EbuyContext context)
		{
			#region Products,Categories,Authors
			if (!context.Products.Any())
			{
				var bogo1 = new Bogo() { BogoId = 1, BogoLevel = 1 };
				var bogo2 = new Bogo() { BogoId = 2, BogoLevel = 2 };
				var bogo3 = new Bogo() { BogoId = 3, BogoLevel = 3 };
				var bogo4 = new Bogo() { BogoId = 4, BogoLevel = 4 };

				var p1 = new Product()
				{
					Category = new Category()
					{
						CategoryId = (int)CategoryType.Book,
						CategoryType = CategoryType.Book
					},
					Title = "Harry Potter and the Sorcerer's Stone",
					Author = new Author()
					{
						AuthorId = 12345,
						AuthorName = "J K Rolling"
					},
					PublicationDate = new DateTime(1998, 7, 2),
					ProductAbstract = "aa",
					Price = 200,
					Bogo = bogo1
				};

				var p2 = new Product()
				{
					Category = new Category()
					{
						CategoryId = (int)CategoryType.Book,
						CategoryType = CategoryType.Book
					},
					Title = "The Hunger Games",
					Author = new Author()
					{
						AuthorId = 3928,
						AuthorName = "Suzanne Collins"
					},
					PublicationDate = new DateTime(2006, 6, 21),
					ProductAbstract = "aa",
					Price = 150,
					Bogo = bogo2
				};

				var p3 = new Product()
				{
					Category = new Category()
					{
						CategoryId = (int)CategoryType.Book,
						CategoryType = CategoryType.Book
					},
					Title = "The Book Thief",
					Author = new Author()
					{
						AuthorId = 3948,
						AuthorName = "Markus Zusak"
					},
					PublicationDate = new DateTime(1993, 12, 7),
					ProductAbstract = "aa",
					Price = 170,
					Bogo = bogo3
				};

				var p4 = new Product()
				{
					Category = new Category()
					{
						CategoryId = (int)CategoryType.Article,
						CategoryType = CategoryType.Article
					},
					Title = "Twilight",
					Author = new Author()
					{
						AuthorId = 2938,
						AuthorName = "Stephenie Meyer"
					},
					PublicationDate = new DateTime(2012, 6, 4),
					ProductAbstract = "aa",
					Price = 210,
					Bogo = bogo4
				};
				var p5 = new Product()
				{
					Category = new Category()
					{
						CategoryId = (int)CategoryType.Book,
						CategoryType = CategoryType.Book
					},
					Title = "Harry Potter and the Chamber of Secrets",
					Author = new Author()
					{
						AuthorId = 12345,
						AuthorName = "J K Rolling"
					},
					PublicationDate = new DateTime(1999, 7, 2),
					ProductAbstract = "aa",
					Price = 200,
					Bogo = bogo1
				};

				var products = new List<Product>()
				{
					p1,p2,p3,p4,p5
				};
				context.Products.AddRange(products);
				context.SaveChanges();
			}
			#endregion

			#region DeliveryModes
			if (!context.DeliveryModes.Any())
			{
				var deliveryMode1 = new DeliveryModes()
				{
					ModeId = (int)DeliveryMode.electronically,
					Mode = DeliveryMode.electronically
				};
				var deliveryMode2 = new DeliveryModes()
				{
					ModeId = (int)DeliveryMode.hard,
					Mode = DeliveryMode.hard
				};
				var deliverymodes = new List<DeliveryModes>()
				{
					deliveryMode1,deliveryMode2
				};
				context.DeliveryModes.AddRange(deliverymodes);
				context.SaveChanges();
			}
			#endregion

			#region Areas, Countries

			if (!context.CountryAreas.Any())
			{
				var area1 = new ShipmentArea()
				{
					ShipmentAreaId = 1,
					Area = "North America"
				};

				var area2 = new ShipmentArea()
				{
					ShipmentAreaId = 2,
					Area = "Asia"
				};

				var area3 = new ShipmentArea()
				{
					ShipmentAreaId = 3,
					Area = "Europe"
				};

				var area4 = new ShipmentArea()
				{
					ShipmentAreaId = 4,
					Area = "Australia"
				};


				var country1 = new CountryArea()
				{
					//CountryId = 1,
					Country = "USA",
					ShipmentArea = area1
				};
				var country2 = new CountryArea()
				{
					//CountryId = 2,
					Country = "Canada",
					ShipmentArea = area1
				};
				var country3 = new CountryArea()
				{
					//CountryId = 3,
					Country = "Israel",
					ShipmentArea = area2
				};
				var country4 = new CountryArea()
				{
					//CountryId = 4,
					Country = "Japan",
					ShipmentArea = area2
				};
				var country5 = new CountryArea()
				{
					//CountryId = 5,
					Country = "China",
					ShipmentArea = area2
				};
				var country6 = new CountryArea()
				{
					//CountryId = 6,
					Country = "Germany",
					ShipmentArea = area3
				};
				var country7 = new CountryArea()
				{
					//CountryId = 7,
					Country = "Italy",
					ShipmentArea = area3
				};
				var country8 = new CountryArea()
				{
					//CountryId = 8,
					Country = "Australia",
					ShipmentArea = new ShipmentArea()
					{
						ShipmentAreaId = 4,
						Area = "Australia"
					}
				};
				var _countryAreas = new List<CountryArea>()
				{
					country1,country2,country3,country4,country5,country6,country7,country8
				};

				var company1 = new ShipmentCompany()
				{
					ShipmentCompanyId = 1,
					CompanyName = "Fedex"
				};
				var company2 = new ShipmentCompany()
				{
					ShipmentCompanyId = 2,
					CompanyName = "PickPack"
				};
				var company3 = new ShipmentCompany()
				{
					ShipmentCompanyId = 3,
					CompanyName = "HFD"
				};
				var company4 = new ShipmentCompany()
				{
					ShipmentCompanyId = 4,
					CompanyName = "DHL"
				};
				var companies = new List<ShipmentCompany>()
				{
					company1, company2, company3, company4
				};

				var shipmentOption1 = new ShipmentOptions()
				{
					ShipmentOptionId = (int)ShipmentOption.AirStandard,
					ShipmentOption = ShipmentOption.AirStandard
				};
				var shipmentOption2 = new ShipmentOptions()
				{
					ShipmentOptionId = (int)ShipmentOption.AirExpress,
					ShipmentOption = ShipmentOption.AirExpress
				};
				var shipmentOption3 = new ShipmentOptions()
				{
					ShipmentOptionId = (int)ShipmentOption.Boat,
					ShipmentOption = ShipmentOption.Boat
				};

				var _shipmentOptions = new List<ShipmentOptions>()
				{
					shipmentOption1, shipmentOption2,shipmentOption3
				};

				var shipmentPrice1 = new ShipmentPrice()
				{
					ShipmentArea = area1,
					ShipmentOption = shipmentOption1,
					ShipmentCompany = company1,
					BasicCharge = 500,
					ShipmentDuration = 7
				};
				var shipmentPrice2 = new ShipmentPrice()
				{
					ShipmentArea = area2,
					ShipmentOption = shipmentOption1,
					ShipmentCompany = company1,
					BasicCharge = 1500,
					ShipmentDuration = 5
				};
				var shipmentPrice3 = new ShipmentPrice()
				{
					ShipmentArea = area2,
					ShipmentOption = shipmentOption2,
					ShipmentCompany = company2,
					BasicCharge = 2000,
					ShipmentDuration = 2
				};
				var shipmentPrice4 = new ShipmentPrice()
				{
					ShipmentArea = area3,
					ShipmentOption = shipmentOption3,
					ShipmentCompany = company3,
					BasicCharge = 1700,
					ShipmentDuration = 5
				};
				var shipmentPrice5 = new ShipmentPrice()
				{
					ShipmentArea = area4,
					ShipmentOption = shipmentOption3,
					ShipmentCompany = company3,
					BasicCharge = 1000,
					ShipmentDuration = 6
				};
				var shipmentPrice6 = new ShipmentPrice()
				{
					ShipmentArea = area4,
					ShipmentOption = shipmentOption1,
					ShipmentCompany = company4,
					BasicCharge = 3000,
					ShipmentDuration = 5
				};
				var _shipmentPrice = new List<ShipmentPrice>()
				{
					shipmentPrice1, shipmentPrice2, shipmentPrice3, shipmentPrice4, shipmentPrice5, shipmentPrice6
				};
				var member = new ClubMember()
				{
					City = "Tel Aviv",
					MemberId = 2009558205,
					//Customer = new Customer()
					//{
					//	CustomerId = 2009558205,
					//	IsClubMember = true
					//},
					//Country = new CountryArea()
					//{
					//	CountryId = 3,
					//	Country = "Israel"
					//},
					Email = "orrmorad@gmail.com",
					LoginName = "orrmorad",
					Password = "1234",
					FirstRegistration = new DateTime(),
					HouseNumber = 1,
					Street = "Habaron Hirsh",
					Phone = "0509815894"
				};
				country3.ClubMembers.Add(member);
				context.CountryAreas.AddRange(_countryAreas);
				context.ShipmentCompanies.AddRange(companies);
				context.ShipmentOptions.AddRange(_shipmentOptions);
				context.ShipmentPrices.AddRange(_shipmentPrice);
				context.SaveChanges();
			}

			if (!context.CreditCardTypes.Any())
			{
				var card1 = new CreditCardTypes()
				{
					Type = CreditCardType.AmericanExpress,
					Prefix = 1234,
                    NumOfDigit = 15
                };

				var card2 = new CreditCardTypes()
				{
					Type = CreditCardType.Mastercard,
					Prefix = 5326,
                   NumOfDigit = 16
				};

				var card3 = new CreditCardTypes()
				{
					Type = CreditCardType.Visa,
					Prefix = 5678,
                    NumOfDigit = 16
                };
				var cards = new List<CreditCardTypes>()
				{
					card1,card2,card3
				};
				context.CreditCardTypes.AddRange(cards);
				context.SaveChanges();
			}

			#endregion
		}
	}
}
