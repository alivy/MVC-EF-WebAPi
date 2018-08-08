using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RechargeExtractionImport : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TradeName{ get; set; }
        public string TradeOrderNumber{ get; set; }
        public decimal TradeMoneyNum{ get; set; }
        public decimal TradePoundage{ get; set; }
        public decimal TradeAccountNum{ get; set; }
        public DateTime TradeTime{ get; set; }
        public int TradeState{ get; set; }
        public string BatchNo{ get; set; }
        public int OperateUid{ get; set; }
        public string TemplatePath{ get; set; }
        public DateTime ImportTime{ get; set; }
    }
}
