using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_SubjectMoneyBackTypeService : ServiceBase<T_SubjectMoneyBackType>
    {
       
    }

    public class T_SubjectMoneyBackType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public int? Sort{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
