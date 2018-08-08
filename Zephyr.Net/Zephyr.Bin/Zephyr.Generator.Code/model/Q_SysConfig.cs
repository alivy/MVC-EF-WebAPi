using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SysConfigService : ServiceBase<Q_SysConfig>
    {
       
    }

    public class Q_SysConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public int? Status{ get; set; }
        public string Description{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
