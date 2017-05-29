using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using Model.Global;

namespace HomeCFOContext.SeedData
{
    public class GlobalSeed
    {
        private Context globalContext;

        public GlobalSeed(ref Context context)
        {
            globalContext = context;
        }

        public void AddStatementClassifications(string pathtofile)
        {
            IList<StatementClassification> globalStatementClassifications = new List<StatementClassification>();

            //add seed data here

            foreach (StatementClassification item in globalStatementClassifications)
                globalContext.StatementClassifications.Add(item);
        }

        public void AddGlobalGroupings(string pathtofile)
        {
            IList<Grouping> globalGroupings = new List<Grouping>();

            //add seed data here

            foreach (Grouping item in globalGroupings)
                globalContext.Groupings.Add(item);

        }

        public void AddGlobalAccounts(string pathtofile)
        {
            IList<Account> globalAccounts = new List<Account>();

            //add seed data here

            foreach (Account item in globalAccounts)
                globalContext.Accounts.Add(item);
        }
    }
}
