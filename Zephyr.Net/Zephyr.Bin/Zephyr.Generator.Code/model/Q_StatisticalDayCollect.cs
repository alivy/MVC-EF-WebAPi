using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_StatisticalDayCollect : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public DateTime? RepayTime{ get; set; }
        public decimal? CurPrincipal{ get; set; }
        public decimal? CurInterest{ get; set; }
        public decimal? Profit{ get; set; }
        public DateTime? AddTime{ get; set; }
        public decimal? YiSource{ get; set; }
        public decimal? NotYiSource{ get; set; }
    }
}
