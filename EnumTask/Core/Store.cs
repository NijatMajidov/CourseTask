using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Store
    {
        Product[] Products;
        
        public Store()
        {
            Products = new Product[0];
        }

        public void AddProducts(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public void RemoveProductByNo(int no)
        {
            Product[] newProducts = { };
            foreach(Product pro in Products) 
            {
                if(pro.No != no)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = pro;
                }
            }

            Products = newProducts;
        }

        public Product[] FilterProductsByType(Enums type) 
        {
            Product[] filProducts = { };

            for(int i=0; i<Products.Length; i++)
            {
                if (Products[i].Type == type)
                {
                    Array.Resize(ref filProducts, filProducts.Length + 1);
                    filProducts[filProducts.Length - 1] = Products[i];
                }
            }

            return filProducts;
        }

        public Product[] FilterProductsByName(string name)
        {
            Product[] filProducts = { };

            foreach (Product pro in Products)
            {
                if (pro.Name == name)
                {
                    Array.Resize(ref filProducts, filProducts.Length + 1);
                    filProducts[filProducts.Length - 1] = pro;
                }
            }

            return filProducts;
        }


    }
}
