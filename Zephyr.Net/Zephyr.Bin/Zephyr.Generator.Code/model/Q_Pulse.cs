using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_PulseService : ServiceBase<Q_Pulse>
    {
       
    }

    public class Q_Pulse : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public int Num{ get; set; }
        public DateTime AddTime{ get; set; }
        public string desc{ get; set; }
        public int IsReset{ get; set; }
        public DateTime UpdateTime{ get; set; }
    }
}
