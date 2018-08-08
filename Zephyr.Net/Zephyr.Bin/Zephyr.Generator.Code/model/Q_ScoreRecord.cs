using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ScoreRecordService : ServiceBase<Q_ScoreRecord>
    {
       
    }

    public class Q_ScoreRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public int? TradeAction{ get; set; }
        public int? TradeType{ get; set; }
        public string TradeRemark{ get; set; }
        public int? TotalScore{ get; set; }
        public int? InNum{ get; set; }
        public int? OutNum{ get; set; }
        public string OrderNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? SignNum{ get; set; }
    }
}
