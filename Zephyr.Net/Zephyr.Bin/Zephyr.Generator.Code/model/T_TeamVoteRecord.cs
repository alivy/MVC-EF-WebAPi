using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_TeamVoteRecordService : ServiceBase<T_TeamVoteRecord>
    {
       
    }

    public class T_TeamVoteRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? TeamId{ get; set; }
        public int? UserId{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
