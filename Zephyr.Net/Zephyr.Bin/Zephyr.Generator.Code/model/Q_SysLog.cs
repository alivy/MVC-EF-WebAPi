using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SysLogService : ServiceBase<Q_SysLog>
    {
       
    }

    public class Q_SysLog : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string Desc{ get; set; }
        public int? State{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
