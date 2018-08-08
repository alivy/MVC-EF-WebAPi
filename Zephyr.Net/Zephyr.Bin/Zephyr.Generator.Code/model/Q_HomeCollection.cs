using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_HomeCollection : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public decimal? InvestSum{ get; set; }
        public int? TradeCount{ get; set; }
        public decimal? EarnSum{ get; set; }
        public decimal? CollectSum{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
