using ShoppingCart.Domain.BaseTypes;
using ShoppingCart.Domain.EntityIds;
using ShoppingCart.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShoppingCart.Domain.Entities
{
    public sealed class Product : AggregateRoot<ProductId>
    {
        private readonly List<Review> _reviews = new();
        private Product(
            ProductId productId,
            ProductName productName,
            Price price,
            UomCode uomCode,
            Revision revision
            ): base (productId)
        {
            ProductName = productName;
            Price = price;
            UomCode = uomCode;
            Revision = revision;
        }
     
        public ProductName ProductName { get; private set; }
        public Revision Revision { get; private set; }
        public Price Price  { get; private set; }
        public UomCode UomCode { get; private set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public IReadOnlyCollection<Review> Reviews  => _reviews.AsReadOnly();
        public static Product Create(ProductId id, ProductName productName, Price price, UomCode uomCode, Revision revision)
        {
            var product = new Product
            (id, productName, price, uomCode, revision);
            return product;
                
        }
        public Review AddReview(Review review)
        {
            _reviews.Add(review);
            return review;
               
        }
        public bool RemoveReview(Review revew)
        {
            return _reviews.Remove(revew);
        }
        public void UpdatePrice(Price price)
        {
            Price = price;
        }

        public void UpdateUomCode(UomCode uomCode)
            {
                UomCode = uomCode;
            }



        
    }
}
