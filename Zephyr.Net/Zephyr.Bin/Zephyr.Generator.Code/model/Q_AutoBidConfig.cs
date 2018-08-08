using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_AutoBidConfig : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal AutoNum{ get; set; }
        public decimal SaveNum{ get; set; }
        public string Day{ get; set; }
        public string LV{ get; set; }
        public int State{ get; set; }
        public int? IsAll{ get; set; }
    }
}
