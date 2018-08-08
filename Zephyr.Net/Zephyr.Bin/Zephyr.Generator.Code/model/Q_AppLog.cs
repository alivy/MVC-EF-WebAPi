using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AppLogService : ServiceBase<Q_AppLog>
    {
       
    }

    public class Q_AppLog : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? LogType{ get; set; }
        public string LogInfo{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
