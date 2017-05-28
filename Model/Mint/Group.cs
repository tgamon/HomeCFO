﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mint
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
