using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore1.Models
{
    public class FakeProductRepository  //:IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product {Name="Football",Price=25 },
             new Product {Name="Basketball",Price=34 },
              new Product {Name="Surf Board",Price=100 }


        }.AsQueryable<Product>();
    }
}
