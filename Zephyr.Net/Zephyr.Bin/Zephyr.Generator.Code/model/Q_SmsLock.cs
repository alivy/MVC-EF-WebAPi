using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SmsLockService : ServiceBase<Q_SmsLock>
    {
       
    }

    public class Q_SmsLock : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ip{ get; set; }
        public int? State{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? Uptime{ get; set; }
    }
}
