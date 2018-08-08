using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class C_ChipsTypeService : ServiceBase<C_ChipsType>
    {
       
    }

    public class C_ChipsType : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public DateTime AddTime{ get; set; }
        public int SortNum{ get; set; }
    }
}
