using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_PlatFormSendRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int FormUid{ get; set; }
        public string OrderNumber{ get; set; }
        public string GoodsMark{ get; set; }
        public decimal GoodSprice{ get; set; }
        public string GoodsName{ get; set; }
        public string Status{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? ReState{ get; set; }
        public string ReMsg{ get; set; }
    }
}
