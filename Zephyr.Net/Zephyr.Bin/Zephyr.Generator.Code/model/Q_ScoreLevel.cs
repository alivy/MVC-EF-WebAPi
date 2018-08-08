using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ScoreLevel : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public decimal MinInvest{ get; set; }
        public decimal MaxInvest{ get; set; }
        public decimal InvestCoefficient{ get; set; }
        public int IsFestival{ get; set; }
        public int BirthdayRedNum{ get; set; }
        public int IsWithdrawFree{ get; set; }
        public int IsTtz{ get; set; }
        public int IsYearReward{ get; set; }
        public int LineFree{ get; set; }
        public int IsDedicatedService{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? LVBond{ get; set; }
    }
}
