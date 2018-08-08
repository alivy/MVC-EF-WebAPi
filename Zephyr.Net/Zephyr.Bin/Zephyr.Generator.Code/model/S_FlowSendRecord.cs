using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowSendRecordService : ServiceBase<S_FlowSendRecord>
    {
       
    }

    public class S_FlowSendRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? ProductId{ get; set; }
        public string OrderNum{ get; set; }
        public string MobileNum{ get; set; }
        public int? State{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? FlowReceiveRecordId{ get; set; }
        public string FlowReceiveOrderNum{ get; set; }
    }
}
