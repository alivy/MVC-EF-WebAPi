using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_TeamInfoService : ServiceBase<T_TeamInfo>
    {
       
    }

    public class T_TeamInfo : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string TeamName{ get; set; }
        public string TeamImg{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? VoteCount{ get; set; }
        public int? CanVote{ get; set; }
    }
}
