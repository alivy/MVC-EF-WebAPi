using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_R_ActioInfo_ActionGroupService : ServiceBase<Q_R_ActioInfo_ActionGroup>
    {
       
    }

    public class Q_R_ActioInfo_ActionGroup : ModelBase
    {

        [PrimaryKey]
        public int ActionInfoId{ get; set; }
        [PrimaryKey]
        public int ActionGroupId{ get; set; }
    }
}
