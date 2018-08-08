using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class C_ChipsSpaceTypeService : ServiceBase<C_ChipsSpaceType>
    {
       
    }

    public class C_ChipsSpaceType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
