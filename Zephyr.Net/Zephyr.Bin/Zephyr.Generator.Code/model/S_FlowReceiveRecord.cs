using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowReceiveRecordService : ServiceBase<S_FlowReceiveRecord>
    {
       
    }

    public class S_FlowReceiveRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string FlowReceiveOrderNum{ get; set; }
        public int? State{ get; set; }
        public string Remark{ get; set; }
        public int? Type{ get; set; }
        public int? UserId{ get; set; }
        public int? SendCount{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
