using ORMTestShopApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTestShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertUsers();
            //InsertAddresses();

            using (var db = new ShopAppEntities())
            {
                int[] ids = new int[2] { 1, 2 };
                var p = db.products.Find(1);

                //p.Categories = ids.Select(cid => new ProductCategories)

                db.SaveChanges();

                #region Old
                //var user = db.Users.FirstOrDefault(i => i.Username == "furkandede");

                //if (user != null)
                //{
                //    db.Addresses.AddRange(new List<Address>()
                //    {
                //        new Address() { FullName = "Furkan Dede", Title = "Ev Adresi 2", Body = "Ankara", UserId = user.ID},
                //        new Address() { FullName = "Furkan Dede", Title = "İş Adresi 2", Body = "Ankara", UserId = user.ID},
                //        new Address() { FullName = "Furkan Dede", Title = "Ev Adresi 3", Body = "Ankara", UserId = user.ID}
                //    });
                //    db.SaveChanges();
                //}

                //var products = new List<product>()
                //{
                //    new product() { ProductName = "Samsun S5", ProductPrice = 2000},
                //    new product() { ProductName = "Samsun S6", ProductPrice = 3000},
                //    new product() { ProductName = "Samsun S7", ProductPrice = 4000},
                //    new product() { ProductName = "Samsun S8", ProductPrice = 5000}
                //};

                //db.products.AddRange(products);

                //var categories = new List<Category>()
                //{
                //    new Category() { Name = "Telefon"},
                //    new Category() { Name = "Elektronik" },
                //    new Category() { Name = "Bilgisayar" }
                //};

                //db.Categories.AddRange(categories);
                #endregion
            }
        }

        static void InsertUsers()
        {
            var users = new List<User>(){
                new User(){ Username = "furkandede", Email = "furkandede@outlook.com.tr" },
                new User(){ Username = "didenurdede", Email = "didenurdede@outlook.com.tr" },
                new User(){ Username = "esrabal", Email = "esrabal@outlook.com.tr" },
                new User(){ Username = "maykılceksın", Email = "maykılceksın@outlook.com.tr" }
            };

            using (var db = new ShopAppEntities())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }

        static void InsertAddresses()
        {
            var addresses = new List<Address>()
            {
                new Address() {FullName = "Furkan Dede", Title = "Ev Adresi", Body = "İstanbul", UserId = 1},
                new Address() {FullName = "Furkan Dede", Title = "İş Adresi", Body = "İstanbul", UserId = 1},
                new Address() {FullName = "Didenur Dede", Title = "Ev Adresi", Body = "Ankara", UserId = 2},
                new Address() {FullName = "Esra Bal", Title = "Ev Adresi", Body = "İstanbul", UserId = 3},
                new Address() {FullName = "Esra Bal", Title = "İş Adresi", Body = "İstanbul", UserId = 3},
                new Address() {FullName = "Maykıl Ceksın", Title = "İş Adresi", Body = "Kocaeli", UserId = 4},
            };

            using (var db = new ShopAppEntities())
            {
                db.Addresses.AddRange(addresses);
                db.SaveChanges();
            };
        }
    }
}
