using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BrowsingPlatformService : ServiceBase<Q_BrowsingPlatform>
    {
       
    }

    public class Q_BrowsingPlatform : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string PlatformName{ get; set; }
        public string LinkName{ get; set; }
        public string LinkUrl{ get; set; }
        public int LinkType{ get; set; }
        public int VisitCount{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
