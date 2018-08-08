using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_R_UserInfo_DeptService : ServiceBase<Q_R_UserInfo_Dept>
    {
       
    }

    public class Q_R_UserInfo_Dept : ModelBase
    {

        [PrimaryKey]
        public int DeptId{ get; set; }
        [PrimaryKey]
        public int UserId{ get; set; }
    }
}
