using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SysEmailConfigService : ServiceBase<Q_SysEmailConfig>
    {
       
    }

    public class Q_SysEmailConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Smtp{ get; set; }
        public string Port{ get; set; }
        public string Email{ get; set; }
        public string PassWord{ get; set; }
        public string FromName{ get; set; }
    }
}
