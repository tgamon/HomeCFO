using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.Global
{
    [DelimitedRecord(",")]
    public class StatementClassification
    {
        public int StatementClassificationId { get; set; }
        public int SortOrder { get; set; }
        public bool BalanceSheet { get; set; }
        public string Name { get; set; }

        public virtual List<Grouping> Groupings { get; set; }
    }
}
