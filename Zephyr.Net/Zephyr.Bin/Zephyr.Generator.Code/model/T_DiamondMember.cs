using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_DiamondMemberService : ServiceBase<T_DiamondMember>
    {
       
    }

    public class T_DiamondMember : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int Type{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime UpdateTime{ get; set; }
        public int IsDel{ get; set; }
    }
}
