using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_DiamondMemberRuleService : ServiceBase<T_DiamondMemberRule>
    {
       
    }

    public class T_DiamondMemberRule : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public decimal MinInvest{ get; set; }
        public decimal MaxInvest{ get; set; }
        public decimal IncomeLv{ get; set; }
        public string Description{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
