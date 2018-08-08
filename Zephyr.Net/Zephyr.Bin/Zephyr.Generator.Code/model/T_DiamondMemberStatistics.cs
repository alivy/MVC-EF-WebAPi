using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_DiamondMemberStatisticsService : ServiceBase<T_DiamondMemberStatistics>
    {
       
    }

    public class T_DiamondMemberStatistics : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Pid{ get; set; }
        public decimal SumInverstNum{ get; set; }
        public decimal SumProfit{ get; set; }
        public decimal IncomeLv{ get; set; }
        public decimal PSumProfit{ get; set; }
        public int ISAuto{ get; set; }
        public string OrderNum{ get; set; }
        public int IsInput{ get; set; }
        public DateTime AddTime{ get; set; }
        public string TradeTime{ get; set; }
    }
}
