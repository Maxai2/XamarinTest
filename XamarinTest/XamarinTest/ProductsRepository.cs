using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace XamarinTest
{
    public class ProductsRepository
    {
        private readonly SQLiteConnection db;

        public ProductsRepository(string dbName)
        {
            var service = DependencyService.Get<ISqliteService>();
            if (service == null)
            {
                throw new Exception("wtf");
            }
            var dbPath = service.GetDbPath(dbName);
            this.db = new SQLiteConnection(dbPath);
            this.db.CreateTable<Product>();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.db.Table<Product>().ToList();
        }

        public Product Add(Product product)
        {
            this.db.Insert(product);
            return this.db.Get<Product>(p => p.Title == product.Title);
        }
    }
}
