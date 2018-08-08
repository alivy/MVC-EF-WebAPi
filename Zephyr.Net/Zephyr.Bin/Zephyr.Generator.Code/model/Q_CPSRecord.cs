using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CPSRecordService : ServiceBase<Q_CPSRecord>
    {
       
    }

    public class Q_CPSRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal InvestNum{ get; set; }
        public DateTime InvestTime{ get; set; }
        public int Day{ get; set; }
        public int SubjectPayId{ get; set; }
        public int SubjectBidId{ get; set; }
        public DateTime RePayTime{ get; set; }
        public int RePayPeriods{ get; set; }
        public string TradeTime{ get; set; }
        public string Remarks{ get; set; }
        public int BidType{ get; set; }
    }
}
