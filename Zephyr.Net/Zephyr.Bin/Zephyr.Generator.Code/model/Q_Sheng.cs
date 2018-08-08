using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ShengService : ServiceBase<Q_Sheng>
    {
       
    }

    public class Q_Sheng : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public string sname{ get; set; }
    }
}
