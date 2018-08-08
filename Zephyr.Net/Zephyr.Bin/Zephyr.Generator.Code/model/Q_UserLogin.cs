using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UserLoginService : ServiceBase<Q_UserLogin>
    {
       
    }

    public class Q_UserLogin : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int Type{ get; set; }
        public string IP{ get; set; }
        public int? State{ get; set; }
        public string Browser{ get; set; }
        public int? LoginHash{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
