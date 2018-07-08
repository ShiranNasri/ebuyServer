using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EbuyProject.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EbuyProject.Services
{
    public class ProductRepository : IProductRepository
    {
        private EbuyContext ctx;

        public ProductRepository(EbuyContext ctx)
        {
            this.ctx = ctx;
        }

        public Product GetProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return ctx.Products.Include(x => x.Author).Include(x => x.Bogo);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return ctx.Authors;
        }

        public IEnumerable<DeliveryModes> GetDeliveryModes()
        {
            return ctx.DeliveryModes;
        }

        public object GetShipmentPrices()
        {
            var data = (from sp in ctx.ShipmentPrices
                        join sar in ctx.ShipmentAreas
                        on sp.ShipmentArea.ShipmentAreaId equals sar.ShipmentAreaId
                        join sc in ctx.ShipmentCompanies
                        on sp.ShipmentCompany.ShipmentCompanyId equals sc.ShipmentCompanyId
                        join so in ctx.ShipmentOptions
                        on sp.ShipmentOption.ShipmentOptionId equals so.ShipmentOptionId
                        select new
                        {
                            ShipmentPriceId = sp.ShipmentPriceId,
                            BasicCharge = sp.BasicCharge,
                            ItemCharge = sp.ItemCharge,
                            Area = sar.Area,
                            CompanyName = sc.CompanyName,
                            ShipmentDuration = sp.ShipmentDuration,
                            ShipmentOption = so.ShipmentOption
                        }

                        ).ToList();

            //var json = JsonConvert.SerializeObject(data);
            return data;
        }

        public IEnumerable<Product> GetProductsByQuery(string title)
        {
            title = null;
            return ctx.Products.Where(p => title == null);
        }

        public IEnumerable<Product> GetProductsByQuery(Query query)
        {
            query.Keywords = query.Keywords != null ? query.Keywords : "";
            query.Author = query.Author != null ? query.Author : "";
            query.Title = query.Title != null ? query.Title : "";
            if (query.StartDate == DateTime.MinValue && query.EndDate == DateTime.MinValue && query.SpecificDate == DateTime.MinValue)
            {
                return ctx.Products.Where(p =>
                    p.Title.StartsWith(query.Title) && p.Author.AuthorName.StartsWith(query.Author)
                    && p.ProductAbstract.StartsWith(query.Keywords)
                );
            }
            else if (query.StartDate == DateTime.MinValue && query.EndDate == DateTime.MinValue && query.IsSpecifiedChecked)
            {
                return ctx.Products.Where(p =>
                      p.Title.StartsWith(query.Title) && p.Author.AuthorName.StartsWith(query.Author)
                      && p.ProductAbstract.StartsWith(query.Keywords) && p.PublicationDate == query.SpecificDate
                );
            }
            else if (query.IsSpecifiedChecked)
            {
                return ctx.Products.Where(p =>
                      p.Title.StartsWith(query.Title) && p.Author.AuthorName.StartsWith(query.Author)
                      && p.ProductAbstract.StartsWith(query.Keywords) && p.PublicationDate >= query.StartDate && p.PublicationDate <= query.EndDate
                );
            }
            return null;
        }

        public void CreateTransaction(Transaction transaction)
        {
            var delivery = ctx.DeliveryModes.Where(del => del.ModeId == transaction.DeliveryMode.ModeId).FirstOrDefault();
            delivery.Transactions.Add(transaction);
            ctx.SaveChanges();
            var shipment = ctx.ShipmentOptions.Where(s => s.ShipmentOptionId == transaction.ShipmentOptions.ShipmentOptionId).FirstOrDefault();
            var cardType = ctx.CreditCardTypes.Where(c => c.Type == transaction.CreditCardTypes.Type).FirstOrDefault();
            shipment.Transactions.Add(transaction);
            cardType.Transactions.Add(transaction);
            ctx.SaveChanges();
        }
    }
}
