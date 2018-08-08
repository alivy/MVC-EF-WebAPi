using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowRewardConfigService : ServiceBase<S_FlowRewardConfig>
    {
       
    }

    public class S_FlowRewardConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? ObjectDay{ get; set; }
        public decimal? MinMoney{ get; set; }
        public string CarrierType{ get; set; }
        public string FlowProductId{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
