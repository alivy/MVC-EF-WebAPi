using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RechargeExtractionImportService : ServiceBase<Q_RechargeExtractionImport>
    {
       
    }

    public class Q_RechargeExtractionImport : ModelBase
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
