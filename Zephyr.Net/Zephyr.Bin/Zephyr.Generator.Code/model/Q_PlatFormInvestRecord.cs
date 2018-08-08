using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_PlatFormInvestRecordService : ServiceBase<Q_PlatFormInvestRecord>
    {
       
    }

    public class Q_PlatFormInvestRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public string InvestOrder{ get; set; }
        public decimal? InvestNum{ get; set; }
        public int? InvestDay{ get; set; }
        public int? InvestType{ get; set; }
        public int? SubjectPayId{ get; set; }
        public int? SubjectBidId{ get; set; }
        public int? TradeAction{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int BidType{ get; set; }
    }
}
