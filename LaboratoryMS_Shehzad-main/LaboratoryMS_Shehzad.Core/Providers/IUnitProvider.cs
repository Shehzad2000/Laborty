using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaboratoryMS_Shehzad.Core.Data;
using LaboratoryMS_Shehzad.Shared.Domain;

namespace LaboratoryMS_Shehzad.Core.Providers
{
    public interface IUnitProvider
    {
        void AddUnit(Unit obj);
        void DeleteUnit(string ID);
        List<Unit> GetUnits();
        Unit GetUnitByID(string ID);

    }
    public class UnitProvider:IUnitProvider
    {
        private readonly MyDbContext db;

        public UnitProvider(MyDbContext mydb)
        {
            db = mydb;
        }
        public void AddUnit(Unit obj)
        {
            db.Units.Add(obj);
            db.SaveChanges();
        }
        public void DeleteUnit(string ID)
        {
            db.Units.Remove(db.Units.Where(x => x.UnitID == ID).FirstOrDefault());
            db.SaveChanges();
        }

        public Unit GetUnitByID(string ID)
        {
            return db.Units.Where(x => x.UnitID == ID).FirstOrDefault();
        }

        public List<Unit> GetUnits()
        {
            return db.Units.ToList();
        }
    }
}
