using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UserFollowRecordService : ServiceBase<Q_UserFollowRecord>
    {
       
    }

    public class Q_UserFollowRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public string Content{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? OperationUid{ get; set; }
        public string Type{ get; set; }
        public string OperationUserName{ get; set; }
        public string UserName{ get; set; }
    }
}
