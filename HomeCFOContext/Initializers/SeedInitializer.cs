using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using Model.Mint;
using Model.Global;
using HomeCFOContext.SeedData;

namespace HomeCFOContext.Initializers
{
    public class SeedInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            //add mint data
            MintSeed mint = new MintSeed(ref context);

            mint.AddMintGroups(@"C:\Users\ilike\OneDrive\Finance_Tom\App\SeedData\Mint_Groups.csv");
            mint.AddMintCategories(@"C:\Users\ilike\OneDrive\Finance_Tom\App\SeedData\Mint_Categories.csv");
            mint.AddMintActivity(@"C:\Users\ilike\OneDrive\Finance_Tom\App\SeedData\Mint_Activities.csv");




            base.Seed(context);
        }

        //add Global seed data
        private IList<StatementClassification> AddGlobalStatementClassification(string pathtofile)
        {

        }

    }
}
