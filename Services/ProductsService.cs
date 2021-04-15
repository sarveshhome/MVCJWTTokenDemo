﻿using MVCJWTTokenDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCJWTTokenDemo.Services
{
    public class ProductsService : IProductsService
    {

        private List<Product> _productItems;
        public ProductsService()
        {
            _productItems = new List<Product>();
        }
        public List<Product> GetProducts()
        {
            return _productItems;
        }
        public Product AddProduct(Product productItem)
        {
            _productItems.Add(productItem);
            return productItem;
        }  
        public Product UpdateProduct(string id, Product productItem)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].ID == id)
                {
                    _productItems[index] = productItem;
                }
            }
            return productItem;
        }
        string IProductsService.DeleteProduct(string id)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].ID == id)
                {
                    _productItems.RemoveAt(index);
                }
            }

            return id;
        }

       

       
    }
}
