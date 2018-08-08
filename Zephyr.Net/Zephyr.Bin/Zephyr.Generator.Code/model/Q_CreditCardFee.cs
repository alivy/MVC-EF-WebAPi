using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CreditCardFee : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public int? POSId{ get; set; }
        public int? BankType{ get; set; }
        public decimal? MoneyNum{ get; set; }
        public decimal? Poundage{ get; set; }
        public decimal? AccountNum{ get; set; }
        public string SerialNumber{ get; set; }
        public string OrderNumber{ get; set; }
        public int? OperateUid{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Remarks{ get; set; }
    }
}
