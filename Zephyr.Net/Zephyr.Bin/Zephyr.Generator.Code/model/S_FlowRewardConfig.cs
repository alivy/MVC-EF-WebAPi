using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowRewardConfig : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? ObjectDay{ get; set; }
        public decimal? MinMoney{ get; set; }
        public string CarrierType{ get; set; }
        public string FlowProductId{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
