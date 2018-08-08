using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_DiamondMemberConfigService : ServiceBase<T_DiamondMemberConfig>
    {
       
    }

    public class T_DiamondMemberConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public int? Status{ get; set; }
        public string Description{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? TypeId{ get; set; }
    }
}
