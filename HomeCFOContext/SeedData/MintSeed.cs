using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using Model.Mint;

namespace HomeCFOContext.SeedData
{
    public class MintSeed
    {
        private Context mintContext;

        public MintSeed(ref Context context)
        {
            mintContext = context;
        }

        public void AddMintGroups(string pathtofile)
        {
            IList<Group> mintGroups = new List<Group>();

            var engine = new FileHelperEngine<Group>();

            mintGroups = engine.ReadFile(pathtofile);

            foreach (Group item in mintGroups)
                mintContext.Groups.Add(item);
        }

        public void AddMintCategories(string pathtofile)
        {
            IList<Category> mintCategory = new List<Category>();

            var engine = new FileHelperEngine<Category>();

            mintCategory = engine.ReadFile(pathtofile);

            foreach (Category item in mintCategory)
                mintContext.Categories.Add(item);
        }

        public void AddMintActivity(string pathtofile)
        {
            IList<Activity> mintActivity = new List<Activity>();

            var engine = new FileHelperEngine<Activity>();

            mintActivity = engine.ReadFile(pathtofile);

            foreach (Activity item in mintActivity)
                mintContext.Activities.Add(item);
        }
    }
}
