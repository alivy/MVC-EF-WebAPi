using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_ActivityOperationRecordService : ServiceBase<T_ActivityOperationRecord>
    {
       
    }

    public class T_ActivityOperationRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public int? TypeNo{ get; set; }
        public int? Stutas{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
