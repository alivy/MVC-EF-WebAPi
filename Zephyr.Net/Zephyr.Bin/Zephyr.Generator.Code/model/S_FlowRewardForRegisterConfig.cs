using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowRewardForRegisterConfigService : ServiceBase<S_FlowRewardForRegisterConfig>
    {
       
    }

    public class S_FlowRewardForRegisterConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? ActionType{ get; set; }
        public string CarrierType{ get; set; }
        public string FlowProductId{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
