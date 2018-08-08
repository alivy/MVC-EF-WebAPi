using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ShiService : ServiceBase<Q_Shi>
    {
       
    }

    public class Q_Shi : ModelBase
    {

        [Identity]
        public int cid{ get; set; }
        public int? sid{ get; set; }
        public string cname{ get; set; }
    }
}
