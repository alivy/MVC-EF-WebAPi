using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_DiamondMemberStatistics : IAggregateRoot
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
