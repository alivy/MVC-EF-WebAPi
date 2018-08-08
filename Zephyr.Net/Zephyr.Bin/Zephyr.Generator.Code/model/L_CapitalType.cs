using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_CapitalTypeService : ServiceBase<L_CapitalType>
    {
       
    }

    public class L_CapitalType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? Sort{ get; set; }
    }
}
