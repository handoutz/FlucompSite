using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DreamSeat;
using DreamSeat.Interfaces;

namespace NewFlucompMVC
{
    public static class Databasing
    {
        const string DBNAME = "flucompsite";
        public static dynamic RetrieveById(string id)
        {
            var cli = new CouchClient();
            var db = cli.GetDatabase(DBNAME);
            var doc = db.GetDocument<JDocument>(id);
            return doc;
        }
        public static JDocument Store(string id, dynamic obj)
        {
            var cli = new CouchClient();
            var db = cli.GetDatabase(DBNAME);
            return db.CreateDocument<JDocument>(obj);
        }
    }
}