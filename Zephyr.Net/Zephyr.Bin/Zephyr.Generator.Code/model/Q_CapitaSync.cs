using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CapitaSync : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal EnableNum{ get; set; }
        public string TradeRemark{ get; set; }
        public string OrderNumber{ get; set; }
        public DateTime? SyncTime{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
    }
}
