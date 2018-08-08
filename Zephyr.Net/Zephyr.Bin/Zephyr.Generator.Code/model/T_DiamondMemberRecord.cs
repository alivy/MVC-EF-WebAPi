using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_DiamondMemberRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal Profit{ get; set; }
        public int Pid{ get; set; }
        public decimal? PNum{ get; set; }
        public decimal IncomeLV{ get; set; }
        public int SubjectPayId{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? SplitTime{ get; set; }
        public string Describe{ get; set; }
        public string TradeTime{ get; set; }
    }
}
