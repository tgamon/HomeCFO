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
    public class ActivityHelper
    {
        public int ActivityId;
        [FieldConverter(ConverterKind.Date,"MM/dd/yyyy")]
        public DateTime Date;
        public string Description;
        public string Original_Description;
        public decimal Amount;
        public string Transaction_Type;
        public string Account_Name;
        public string Labels;
        public string Notes;
        public int CategoryId;

    }
}
