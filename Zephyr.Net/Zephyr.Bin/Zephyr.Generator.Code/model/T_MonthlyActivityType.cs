using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MonthlyActivityTypeService : ServiceBase<T_MonthlyActivityType>
    {
       
    }

    public class T_MonthlyActivityType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string ActionDay{ get; set; }
        public int? BackType{ get; set; }
        public string Remark{ get; set; }
    }
}
