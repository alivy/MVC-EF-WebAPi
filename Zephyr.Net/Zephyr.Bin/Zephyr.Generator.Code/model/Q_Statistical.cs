using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_StatisticalService : ServiceBase<Q_Statistical>
    {
       
    }

    public class Q_Statistical : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string UserName{ get; set; }
        public string FullName{ get; set; }
        public DateTime? TradingTime{ get; set; }
        public string TradingType{ get; set; }
        public string Remark{ get; set; }
        public decimal? RechargeNum{ get; set; }
        public decimal? InvestorNum{ get; set; }
        public decimal? AutoPrize{ get; set; }
        public decimal? LZ{ get; set; }
        public decimal? PaymentNum{ get; set; }
        public decimal? WithdrawalsNum{ get; set; }
        public decimal? TtzIn{ get; set; }
        public decimal? TtzOn{ get; set; }
        public decimal? TtzLV{ get; set; }
        public int? C_Uid{ get; set; }
        public int? C_TradeAction{ get; set; }
        public int? C_TradeType{ get; set; }
        public string C_TradeRemark{ get; set; }
        public string C_TradeObjct{ get; set; }
        public decimal? C_InNum{ get; set; }
        public decimal? C_OutNum{ get; set; }
        public string C_OrderNum{ get; set; }
        public decimal? C_Total{ get; set; }
        public DateTime? C_AddTime{ get; set; }
        public decimal? C_EnableNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Operator{ get; set; }
        public int? State{ get; set; }
        public decimal? TtzUsableSum{ get; set; }
        public decimal? WaitNum{ get; set; }
        public decimal? BalanceNum{ get; set; }
        public decimal? TotalNum{ get; set; }
    }
}
