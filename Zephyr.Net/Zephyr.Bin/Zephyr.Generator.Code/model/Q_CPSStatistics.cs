using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CPSStatistics : IAggregateRoot
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
