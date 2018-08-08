using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RoleService : ServiceBase<Q_Role>
    {
       
    }

    public class Q_Role : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string RoleName{ get; set; }
        public int DelFlag{ get; set; }
        public int? RoleType{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Remark{ get; set; }
    }
}
