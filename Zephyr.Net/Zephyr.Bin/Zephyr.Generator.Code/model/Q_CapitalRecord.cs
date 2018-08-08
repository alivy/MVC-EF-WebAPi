using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CapitalRecordService : ServiceBase<Q_CapitalRecord>
    {
       
    }

    public class Q_CapitalRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int TradeAction{ get; set; }
        public int TradeType{ get; set; }
        public string TradeRemark{ get; set; }
        public string TradeObjct{ get; set; }
        public decimal TotalNum{ get; set; }
        public decimal InNum{ get; set; }
        public decimal OutNum{ get; set; }
        public string OrderNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public decimal? EnableNum{ get; set; }
        public string SerialNumber{ get; set; }
    }
}
