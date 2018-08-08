using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_QuService : ServiceBase<Q_Qu>
    {
       
    }

    public class Q_Qu : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int qid{ get; set; }
        public int sid{ get; set; }
        public int cid{ get; set; }
        public string qname{ get; set; }
    }
}
