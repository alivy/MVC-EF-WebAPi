using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MonthlyActivityRule : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int ActivityId{ get; set; }
        public int InvestDay{ get; set; }
        public decimal MinNum{ get; set; }
        public decimal MaxNum{ get; set; }
        public decimal RewardNum{ get; set; }
        public int BackType{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
