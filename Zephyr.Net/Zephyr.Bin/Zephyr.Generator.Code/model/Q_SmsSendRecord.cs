using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SmsSendRecordService : ServiceBase<Q_SmsSendRecord>
    {
       
    }

    public class Q_SmsSendRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Tel{ get; set; }
        public string Content{ get; set; }
        public int Type{ get; set; }
        public DateTime SendTime{ get; set; }
        public string SendResult{ get; set; }
        public string SendResultRemark{ get; set; }
        public int SendCount{ get; set; }
        public DateTime? LastSendTime{ get; set; }
        public string LastSendResult{ get; set; }
        public string LastSendResultRemark{ get; set; }
    }
}
