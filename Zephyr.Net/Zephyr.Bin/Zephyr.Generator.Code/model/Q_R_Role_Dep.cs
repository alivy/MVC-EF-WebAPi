using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_R_Role_DepService : ServiceBase<Q_R_Role_Dep>
    {
       
    }

    public class Q_R_Role_Dep : ModelBase
    {

        [PrimaryKey]
        public int RoleId{ get; set; }
        [PrimaryKey]
        public int DepId{ get; set; }
    }
}
