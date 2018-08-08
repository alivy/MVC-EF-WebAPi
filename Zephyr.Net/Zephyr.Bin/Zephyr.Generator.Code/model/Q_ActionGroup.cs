using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ActionGroupService : ServiceBase<Q_ActionGroup>
    {
       
    }

    public class Q_ActionGroup : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string GroupName{ get; set; }
        public int? GroupType{ get; set; }
        public int DelFlag{ get; set; }
        public int Sort{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Icon{ get; set; }
    }
}
