using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTestShopApp.Services
{
    class ProductService
    {
        private ShopAppEntities context;

        public ProductService()
        {
            context = new ShopAppEntities();
        }

        public int addNewProduct(product product)
        {
            int returnInt = -1;

            if (product != null)
            {
                context.products.Add(product);
                returnInt = context.SaveChanges();
            }

            return returnInt;
        }
    }
}
