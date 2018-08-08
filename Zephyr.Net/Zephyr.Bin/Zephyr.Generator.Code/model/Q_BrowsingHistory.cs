using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BrowsingHistoryService : ServiceBase<Q_BrowsingHistory>
    {
       
    }

    public class Q_BrowsingHistory : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Browser{ get; set; }
        public int TypeId{ get; set; }
        public DateTime AddTime{ get; set; }
        public string ClientIP{ get; set; }
    }
}
