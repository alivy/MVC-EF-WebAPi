using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MonthlyActivityService : ServiceBase<T_MonthlyActivity>
    {
       
    }

    public class T_MonthlyActivity : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? StartTime{ get; set; }
        public DateTime? EndTime{ get; set; }
        public string Remark{ get; set; }
        public int? ActivityTypeId{ get; set; }
        public int IsWork{ get; set; }
    }
}
