using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_JXWithdrawalRecordService : ServiceBase<T_JXWithdrawalRecord>
    {
       
    }

    public class T_JXWithdrawalRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int TradeType{ get; set; }
        public string TradeRemark{ get; set; }
        public decimal TradeNum{ get; set; }
        public decimal TradeRePayNum{ get; set; }
        public decimal RePayNum{ get; set; }
        public decimal? EnableNum{ get; set; }
        public string OrderNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? SubjectPayId{ get; set; }
        public int? SubjectBidId{ get; set; }
    }
}
