using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CapitaSyncService : ServiceBase<Q_CapitaSync>
    {
       
    }

    public class Q_CapitaSync : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal EnableNum{ get; set; }
        public string TradeRemark{ get; set; }
        public string OrderNumber{ get; set; }
        public DateTime? SyncTime{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
    }
}
