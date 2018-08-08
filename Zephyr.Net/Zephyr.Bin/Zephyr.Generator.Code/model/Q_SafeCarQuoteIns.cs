using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SafeCarQuoteIns : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? quoteId{ get; set; }
        public string kindCode{ get; set; }
        public string kindName{ get; set; }
        public string insuredAmount{ get; set; }
        public string seatNum{ get; set; }
        public string benchmarkPremium{ get; set; }
        public string discount{ get; set; }
        public string commission{ get; set; }
        public string premium{ get; set; }
        public DateTime? addTime{ get; set; }
    }
}
