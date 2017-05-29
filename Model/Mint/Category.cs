using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.Mint
{
    [DelimitedRecord(",")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
