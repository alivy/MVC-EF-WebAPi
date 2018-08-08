using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CPSStatisticsService : ServiceBase<Q_CPSStatistics>
    {
       
    }

    public class Q_CPSStatistics : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Consultant{ get; set; }
        public decimal InvestNum{ get; set; }
        public string TradeTime{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Remarks{ get; set; }
    }
}
