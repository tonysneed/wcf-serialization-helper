using System;
using System.Collections.Generic;
using System.Linq;
using WcfSerializationHelper.Sample.Data;
using WcfSerializationHelper.Sample.Entities;

namespace WcfSerializationHelper.Sample.Core
{
    public class SampleService : ISampleService
    {
        public IEnumerable<Category> GetCategories()
        {
            var categories = MockDatabase.Categories
                .OrderBy(p => p.CategoryName)
                .ToList();
            return categories;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = MockDatabase.Products
                .OrderBy(p => p.ProductName)
                .ToList();
            return products;
        }
    }
}
