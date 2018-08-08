using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UserInfoLoginService : ServiceBase<Q_UserInfoLogin>
    {
       
    }

    public class Q_UserInfoLogin : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int Type{ get; set; }
        public string IP{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Browser{ get; set; }
        public int? LoginHash{ get; set; }
    }
}
