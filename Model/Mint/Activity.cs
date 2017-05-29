using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.Mint
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    public class Activity
    {
        public int ActivityId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Original_Description { get; set; }
        public decimal Amount { get; set; }
        public string Transaction_Type { get; set; }
        public string Account_Name { get; set; }
        public string Labels { get; set; }
        public string Notes { get; set; }

        public int CategoryId { get; set; }
        //public virtual Category Category { get; set; }

    }
}
