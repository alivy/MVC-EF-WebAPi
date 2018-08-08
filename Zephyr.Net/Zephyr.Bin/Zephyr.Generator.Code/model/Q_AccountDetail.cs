using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AccountDetailService : ServiceBase<Q_AccountDetail>
    {
       
    }

    public class Q_AccountDetail : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string AccDate{ get; set; }
        public string InpDate{ get; set; }
        public string RelDate{ get; set; }
        public string InpTime{ get; set; }
        public int TraceNo{ get; set; }
        public string AccountId{ get; set; }
        public string TranType{ get; set; }
        public string OrFlag{ get; set; }
        public decimal TxAmount{ get; set; }
        public string TxFlag{ get; set; }
        public string Describe{ get; set; }
        public string Currency{ get; set; }
        public decimal CurrBal{ get; set; }
        public string ForAccountId{ get; set; }
        public string OrderNum{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
