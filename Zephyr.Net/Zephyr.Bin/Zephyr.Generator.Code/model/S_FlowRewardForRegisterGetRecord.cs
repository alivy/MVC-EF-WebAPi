using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowRewardForRegisterGetRecordService : ServiceBase<S_FlowRewardForRegisterGetRecord>
    {
       
    }

    public class S_FlowRewardForRegisterGetRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? UserId{ get; set; }
        public int? FlowRewardForRegisterConfigId{ get; set; }
        public int? TerminalType{ get; set; }
        public int? State{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
