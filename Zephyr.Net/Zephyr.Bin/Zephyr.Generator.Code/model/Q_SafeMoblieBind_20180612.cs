using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeMoblieBind_20180612Service : ServiceBase<Q_SafeMoblieBind_20180612>
    {
       
    }

    public class Q_SafeMoblieBind_20180612 : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string MoblieNum{ get; set; }
        public int State{ get; set; }
        public int IsDel{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? UpTime{ get; set; }
    }
}
