using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MoneyRainPulseService : ServiceBase<T_MoneyRainPulse>
    {
       
    }

    public class T_MoneyRainPulse : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Subjectid{ get; set; }
        public int Num{ get; set; }
        public DateTime AddTime{ get; set; }
        public string desc{ get; set; }
    }
}
