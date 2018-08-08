using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ScoreRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public int? TradeAction{ get; set; }
        public int? TradeType{ get; set; }
        public string TradeRemark{ get; set; }
        public int? TotalScore{ get; set; }
        public int? InNum{ get; set; }
        public int? OutNum{ get; set; }
        public string OrderNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? SignNum{ get; set; }
    }
}
