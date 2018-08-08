using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ContinueInvestRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal RePayNum{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal ContinueInvest{ get; set; }
        public decimal RewardNum{ get; set; }
        public int SubjectBidId{ get; set; }
        public int SubjectPayId{ get; set; }
        public int IsGet{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
