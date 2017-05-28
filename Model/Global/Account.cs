using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Global
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string SourceLookup { get; set; }
        public virtual Grouping Grouping { get; set; }
    }
}
