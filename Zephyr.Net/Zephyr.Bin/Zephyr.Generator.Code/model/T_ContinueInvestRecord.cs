using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_ContinueInvestRecordService : ServiceBase<T_ContinueInvestRecord>
    {
       
    }

    public class T_ContinueInvestRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal RePayNum{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal ContinueInvest{ get; set; }
        public decimal RewardNum{ get; set; }
        public int SubjectBidId{ get; set; }
        public int SubjectPayId{ get; set; }
        public int IsGet{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
