using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaboratoryMS_Shehzad.Core.Data;
using LaboratoryMS_Shehzad.Shared.Domain;

namespace LaboratoryMS_Shehzad.Core.Providers
{
    public interface IResultProvider
    {
        void AddResult(Result obj);
        void DeleteResult(string ID);
        List<Result> GetResults();
        Result GetResultByID(string ID);
    }
    public class ResultProvider : IResultProvider
    {
        private readonly MyDbContext db;

        public ResultProvider(MyDbContext db)
        {
            this.db = db;
        }

        public void AddResult(Result obj)
        {
            db.Results.Add(obj);
            db.SaveChanges();
        }

        public void DeleteResult(string ID)
        {
            db.Results.Remove(db.Results.Where(x => x.ResultID == ID).FirstOrDefault());
            db.SaveChanges();
        }

        public Result GetResultByID(string ID)
        {
            return db.Results.Where(x => x.ResultID == ID).FirstOrDefault();
        }

        public List<Result> GetResults()
        {
            return db.Results.ToList();
        }
    }
}
