using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AutoBidConfigService : ServiceBase<Q_AutoBidConfig>
    {
       
    }

    public class Q_AutoBidConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal AutoNum{ get; set; }
        public decimal SaveNum{ get; set; }
        public string Day{ get; set; }
        public string LV{ get; set; }
        public int State{ get; set; }
        public int? IsAll{ get; set; }
    }
}
