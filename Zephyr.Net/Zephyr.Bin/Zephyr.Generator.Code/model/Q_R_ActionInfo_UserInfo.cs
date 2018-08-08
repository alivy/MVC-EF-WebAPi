using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_R_ActionInfo_UserInfoService : ServiceBase<Q_R_ActionInfo_UserInfo>
    {
       
    }

    public class Q_R_ActionInfo_UserInfo : ModelBase
    {

        [PrimaryKey]
        public int UserId{ get; set; }
        [PrimaryKey]
        public int ActionInfoId{ get; set; }
    }
}
