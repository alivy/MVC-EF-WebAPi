using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BrowsingPlatRecordService : ServiceBase<Q_BrowsingPlatRecord>
    {
       
    }

    public class Q_BrowsingPlatRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int BrowsingPlatId{ get; set; }
        public string Browser{ get; set; }
        public string ClientIP{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
