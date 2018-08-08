using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UpdLogService : ServiceBase<Q_UpdLog>
    {
       
    }

    public class Q_UpdLog : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int TypeId{ get; set; }
        public string Remark{ get; set; }
    }
}
