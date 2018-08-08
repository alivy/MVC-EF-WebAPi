using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeEmailBindService : ServiceBase<Q_SafeEmailBind>
    {
       
    }

    public class Q_SafeEmailBind : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string Email{ get; set; }
        public int State{ get; set; }
        public int IsDel{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? UpTime{ get; set; }
    }
}
