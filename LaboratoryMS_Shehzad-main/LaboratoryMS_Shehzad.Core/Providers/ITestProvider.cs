using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaboratoryMS_Shehzad.Core.Data;
using LaboratoryMS_Shehzad.Shared.Domain;

namespace LaboratoryMS_Shehzad.Core.Providers
{
    public interface ITestProvider
    {
        void AddTest(Test obj);
        void DeleteTest(string ID);
        List<Test> GetTests();
        Test GetTestByID(string ID);
    }
    public class TestProvider : ITestProvider
    {
        private readonly MyDbContext db;

        public TestProvider(MyDbContext db)
        {
            this.db = db;
        }

        public void AddTest(Test obj)
        {
            db.Tests.Add(obj);
            db.SaveChanges();
        }

        public void DeleteTest(string ID)
        {
            db.Tests.Remove(db.Tests.Where(x => x.TestID == ID).FirstOrDefault());
            db.SaveChanges();
        }

        public Test GetTestByID(string ID)
        {
           return  db.Tests.Where(x => x.TestID == ID).FirstOrDefault();
        }

        public List<Test> GetTests()
        {
            return db.Tests.ToList();
        }
    }
}
