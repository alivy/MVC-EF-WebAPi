using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_WPUserProfitService : ServiceBase<Q_WPUserProfit>
    {
       
    }

    public class Q_WPUserProfit : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public decimal? UsableSum{ get; set; }
        public decimal? CurrentLV{ get; set; }
        public DateTime? SettlementDate{ get; set; }
        public int? state{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? Q_WpfrId{ get; set; }
        public decimal? InProfit{ get; set; }
    }
}
