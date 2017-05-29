using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Model.FileHelper.MintHelpers
{
    /*Mapping type class to assist intake of strongly typed csv
     * data. This class expects that a mapping function will
     * translate the results to an Entity type class.
     * this is due to the FileHelper API data converter
     * requirements that the type class have public fields whereas
     * Entity framework use properties.
     */
     [DelimitedRecord(",")]
     [IgnoreFirst]
    public class GroupHelper
    {
        public int GroupId;
        public string GroupName;
    }
}
