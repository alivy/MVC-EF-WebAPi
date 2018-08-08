using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowRegister_bakService : ServiceBase<S_FlowRegister_bak>
    {
       
    }

    public class S_FlowRegister_bak : ModelBase
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public int? UserId{ get; set; }
        public int? RecommendUserId{ get; set; }
        public string AgePhase{ get; set; }
        public string MoblieNum{ get; set; }
        public int? RecommendCount{ get; set; }
        public int? GetNum{ get; set; }
        public int? IsNew{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
