using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditCardRecordService : ServiceBase<Q_CreditCardRecord>
    {
       
    }

    public class Q_CreditCardRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public int? Type{ get; set; }
        public int? CreditCardTypeId{ get; set; }
        public string OrderNumber{ get; set; }
        public DateTime? AddTime{ get; set; }
        public decimal? MoneyNum{ get; set; }
        public decimal? Poundage{ get; set; }
        public decimal? AccountNum{ get; set; }
        public int? State{ get; set; }
        public int? OperateUid{ get; set; }
        public string Remarks{ get; set; }
        public int? ImpId{ get; set; }
        public DateTime? TradeTime{ get; set; }
        public string MerchantID{ get; set; }
        public string TradeName{ get; set; }
        public decimal? TradeAmount{ get; set; }
        public decimal? TradePoundage{ get; set; }
        public int? POSID{ get; set; }
        public int? TradeState{ get; set; }
        public string BatchNo{ get; set; }
        public decimal? TotalAmount{ get; set; }
        public int? BankType{ get; set; }
        public decimal PersonNum{ get; set; }
        public decimal PersonFee{ get; set; }
    }
}
