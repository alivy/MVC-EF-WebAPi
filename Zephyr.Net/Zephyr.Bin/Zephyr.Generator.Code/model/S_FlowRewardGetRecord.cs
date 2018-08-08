using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowRewardGetRecordService : ServiceBase<S_FlowRewardGetRecord>
    {
       
    }

    public class S_FlowRewardGetRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? UserId{ get; set; }
        public int? FlowRewardConfigId{ get; set; }
        public int? TerminalType{ get; set; }
        public int? State{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
