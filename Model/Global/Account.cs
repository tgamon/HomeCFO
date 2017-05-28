using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.Global
{
    [DelimitedRecord(",")]
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string SourceLookup { get; set; }

        public int GroupingId { get; set; }
        public virtual Grouping Grouping { get; set; }
    }
}
