using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeCarQuoteInsService : ServiceBase<Q_SafeCarQuoteIns>
    {
       
    }

    public class Q_SafeCarQuoteIns : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? quoteId{ get; set; }
        public string kindCode{ get; set; }
        public string kindName{ get; set; }
        public string insuredAmount{ get; set; }
        public string seatNum{ get; set; }
        public string benchmarkPremium{ get; set; }
        public string discount{ get; set; }
        public string commission{ get; set; }
        public string premium{ get; set; }
        public DateTime? addTime{ get; set; }
    }
}
