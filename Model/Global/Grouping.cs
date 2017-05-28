using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Global
{
    public class Grouping
    {
        public int GroupingId { get; set; }
        public string GroupingName { get; set; }
        public virtual StatementClassification StatementClassification { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}
