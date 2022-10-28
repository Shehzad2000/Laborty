using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaboratoryMS_Shehzad.Core.Data;
using LaboratoryMS_Shehzad.Shared.Domain;

namespace LaboratoryMS_Shehzad.Core.Providers
{
    public interface ITestPriceProvider
    {
        void AddTestPrice(TestPrice obj);
        void DeleteTestPrice(string ID);
        List<TestPrice> GetTestPrices();
        TestPrice GetTestPriceByID(string ID);
    }
    public class TestPriceProvider : ITestPriceProvider
    {
        private readonly MyDbContext db;

        public TestPriceProvider(MyDbContext db)
        {
            this.db = db;
        }

        public void AddTestPrice(TestPrice obj)
        {
            db.TestPrices.Add(obj);
            db.SaveChanges();
        }

   
        public void DeleteTestPrice(string ID)
        {
            db.TestPrices.Remove(db.TestPrices.Where(x => x.TestPriceID == ID).FirstOrDefault());
            db.SaveChanges();
          
        }
  
        TestPrice ITestPriceProvider.GetTestPriceByID(string ID)
        {
            return db.TestPrices.Where(x => x.TestPriceID == ID).FirstOrDefault();
        }

        List<TestPrice> ITestPriceProvider.GetTestPrices()
        {
            return db.TestPrices.ToList();
        }
    }
}
