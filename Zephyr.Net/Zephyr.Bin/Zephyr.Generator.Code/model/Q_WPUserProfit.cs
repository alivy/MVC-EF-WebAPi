using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_WPUserProfit : IAggregateRoot
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
