using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_StatisticalDayCollectService : ServiceBase<Q_StatisticalDayCollect>
    {
       
    }

    public class Q_StatisticalDayCollect : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public DateTime? RepayTime{ get; set; }
        public decimal? CurPrincipal{ get; set; }
        public decimal? CurInterest{ get; set; }
        public decimal? Profit{ get; set; }
        public DateTime? AddTime{ get; set; }
        public decimal? YiSource{ get; set; }
        public decimal? NotYiSource{ get; set; }
    }
}
