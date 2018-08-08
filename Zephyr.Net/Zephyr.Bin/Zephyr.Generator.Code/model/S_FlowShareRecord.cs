using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowShareRecordService : ServiceBase<S_FlowShareRecord>
    {
       
    }

    public class S_FlowShareRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ClientId{ get; set; }
        public int? UserId{ get; set; }
        public string ShareUrl{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string ClientUserId{ get; set; }
        public string OpenId{ get; set; }
    }
}
