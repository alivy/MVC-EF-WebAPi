using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowProduct : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ProductName{ get; set; }
        public string HProductId{ get; set; }
        public int? GetNum{ get; set; }
        public string SortNum{ get; set; }
        public string CarrierType{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
