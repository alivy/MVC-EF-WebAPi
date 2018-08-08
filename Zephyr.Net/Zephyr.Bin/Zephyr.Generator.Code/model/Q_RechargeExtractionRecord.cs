using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RechargeExtractionRecordService : ServiceBase<Q_RechargeExtractionRecord>
    {
       
    }

    public class Q_RechargeExtractionRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public int? Type{ get; set; }
        public string OrderNumber{ get; set; }
        public decimal? MoneyNum{ get; set; }
        public decimal? Poundage{ get; set; }
        public decimal? AccountNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? TradeAction{ get; set; }
        public DateTime? ImportTime{ get; set; }
        public string TradeName{ get; set; }
        public string TradeOrderNumber{ get; set; }
        public decimal? TradeMoneyNum{ get; set; }
        public decimal? TradePoundage{ get; set; }
        public decimal? TradeAccountNum{ get; set; }
        public DateTime? TradeTime{ get; set; }
        public int? TradeState{ get; set; }
        public string BatchNo{ get; set; }
        public int? OperateUid{ get; set; }
        public string Remarks{ get; set; }
    }
}
