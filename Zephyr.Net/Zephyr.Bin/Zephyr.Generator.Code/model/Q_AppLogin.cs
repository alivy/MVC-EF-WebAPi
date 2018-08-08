using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AppLoginService : ServiceBase<Q_AppLogin>
    {
       
    }

    public class Q_AppLogin : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public DateTime LoginTime{ get; set; }
        public DateTime ExpirationTime{ get; set; }
        public string UDID{ get; set; }
        public string Browser{ get; set; }
    }
}
