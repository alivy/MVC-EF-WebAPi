using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_WPDayProfitService : ServiceBase<Q_WPDayProfit>
    {
       
    }

    public class Q_WPDayProfit : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public DateTime? AddTime{ get; set; }
        public decimal? Profit{ get; set; }
        public decimal? In{ get; set; }
        public decimal? Out{ get; set; }
        public string Remark{ get; set; }
        public DateTime? StatisticalDay{ get; set; }
        public string Operator{ get; set; }
    }
}
