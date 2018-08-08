using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditCardFeeService : ServiceBase<Q_CreditCardFee>
    {
       
    }

    public class Q_CreditCardFee : ModelBase
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
