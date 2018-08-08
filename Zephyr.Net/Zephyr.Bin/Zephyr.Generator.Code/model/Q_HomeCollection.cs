using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_HomeCollectionService : ServiceBase<Q_HomeCollection>
    {
       
    }

    public class Q_HomeCollection : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public decimal? InvestSum{ get; set; }
        public int? TradeCount{ get; set; }
        public decimal? EarnSum{ get; set; }
        public decimal? CollectSum{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
