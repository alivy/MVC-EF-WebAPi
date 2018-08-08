using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SendRedBagRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string AccountId{ get; set; }
        public string FullName{ get; set; }
        public int Channel{ get; set; }
        public string BatchNo{ get; set; }
        public int TradeAction{ get; set; }
        public int TradeType{ get; set; }
        public string TradeRemark{ get; set; }
        public decimal TradeNum{ get; set; }
        public int RedBagType{ get; set; }
        public int SubjectBidId{ get; set; }
        public string OrderNum{ get; set; }
        public int IsSendSms{ get; set; }
        public int IsSendInsideMessage{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public int? SubjectPayId{ get; set; }
        public string SerialNumber{ get; set; }
        public string SerialNo{ get; set; }
    }
}
