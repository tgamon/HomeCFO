﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.Global
{
    [DelimitedRecord(",")]
    public class Grouping
    {
        public int GroupingId { get; set; }
        public string GroupingName { get; set; }

        public int StatementClassificationId { get; set; }
        public virtual StatementClassification StatementClassification { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}
