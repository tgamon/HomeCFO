﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.Mint
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        //public virtual IList<Category> Categories { get; set; }
    }
}
