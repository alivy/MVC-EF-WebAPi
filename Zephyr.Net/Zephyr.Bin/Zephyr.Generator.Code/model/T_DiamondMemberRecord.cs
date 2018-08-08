using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_DiamondMemberRecordService : ServiceBase<T_DiamondMemberRecord>
    {
       
    }

    public class T_DiamondMemberRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal Profit{ get; set; }
        public int Pid{ get; set; }
        public decimal? PNum{ get; set; }
        public decimal IncomeLV{ get; set; }
        public int SubjectPayId{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? SplitTime{ get; set; }
        public string Describe{ get; set; }
        public string TradeTime{ get; set; }
    }
}
