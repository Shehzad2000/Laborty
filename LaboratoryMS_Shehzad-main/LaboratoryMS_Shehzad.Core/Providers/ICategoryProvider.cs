using LaboratoryMS_Shehzad.Core.Data;
using LaboratoryMS_Shehzad.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaboratoryMS_Shehzad.Core.Providers
{
    public interface ICategoryProvider
    {
        void AddCategory(Category category);
        void DeleteCategory(string CatID);
        List<Category> AllCategory();
        Category CategoryByID(string CatID);
        Account Login(Account account);
    }
    public class CategoryProvider : ICategoryProvider
    {
        private  MyDbContext db;
        public CategoryProvider(MyDbContext mydb)
        {
            db = mydb;
        }

        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void DeleteCategory(string CatID)
        {
            db.Categories.Remove(db.Categories.Where(x => x.CatID == CatID).FirstOrDefault());
            db.SaveChanges();
        }
        public List<Category> AllCategory()
        {
            return db.Categories.ToList();
        }
        public Category CategoryByID(string CatID)
        {
            return db.Categories.Where(x => x.CatID == CatID).FirstOrDefault();
        }

        public Account Login(Account account)
        {
            return db.Accounts.Where(x => x.Email == account.Email && x.Password == account.Password).FirstOrDefault();
        }
    }
}
