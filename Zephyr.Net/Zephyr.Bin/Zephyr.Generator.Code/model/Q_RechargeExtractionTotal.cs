using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RechargeExtractionTotalService : ServiceBase<Q_RechargeExtractionTotal>
    {
       
    }

    public class Q_RechargeExtractionTotal : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? TradeType{ get; set; }
        public decimal RMoneyNum{ get; set; }
        public decimal RPoundage{ get; set; }
        public decimal RAccountNum{ get; set; }
        public decimal EMoneyNum{ get; set; }
        public decimal EPoundage{ get; set; }
        public decimal EAccountNum{ get; set; }
        public DateTime TradeTime{ get; set; }
        public int TradeAction{ get; set; }
        public decimal? InNum{ get; set; }
        public decimal? InPoundage{ get; set; }
        public decimal? InEnableNum{ get; set; }
        public decimal? OutNum{ get; set; }
        public decimal? OutPoundage{ get; set; }
        public decimal? OutEnableNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? OperateUid{ get; set; }
    }
}
