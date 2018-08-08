using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeCardBindService : ServiceBase<Q_SafeCardBind>
    {
       
    }

    public class Q_SafeCardBind : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string FullName{ get; set; }
        public string CardNum{ get; set; }
        public string Birthday{ get; set; }
        public int Sex{ get; set; }
        public int State{ get; set; }
        public int IsDel{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? UpTime{ get; set; }
        public string Customer_ID{ get; set; }
        public int? AccountType{ get; set; }
    }
}
