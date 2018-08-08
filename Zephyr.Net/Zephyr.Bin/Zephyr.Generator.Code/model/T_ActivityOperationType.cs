using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_ActivityOperationTypeService : ServiceBase<T_ActivityOperationType>
    {
       
    }

    public class T_ActivityOperationType : ModelBase
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public int TypeNo{ get; set; }
        public string TypeName{ get; set; }
        public string ActivityNO{ get; set; }
    }
}
