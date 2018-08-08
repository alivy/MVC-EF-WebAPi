using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MonthlyActivityRuleService : ServiceBase<T_MonthlyActivityRule>
    {
       
    }

    public class T_MonthlyActivityRule : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int ActivityId{ get; set; }
        public int InvestDay{ get; set; }
        public decimal MinNum{ get; set; }
        public decimal MaxNum{ get; set; }
        public decimal RewardNum{ get; set; }
        public int BackType{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
