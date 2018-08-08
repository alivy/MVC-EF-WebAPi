using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_R_Role_ActionGroupService : ServiceBase<Q_R_Role_ActionGroup>
    {
       
    }

    public class Q_R_Role_ActionGroup : ModelBase
    {

        [PrimaryKey]
        public int RoleId{ get; set; }
        [PrimaryKey]
        public int ActionGroupId{ get; set; }
    }
}
