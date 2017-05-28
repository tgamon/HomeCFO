using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.Mint
{
    [DelimitedRecord(",")]
    public class Activity
    {
        public int ActivityId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string OriginalDescription { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public string AccountName { get; set; }
        public string Labels { get; set; }
        public string Notes { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
