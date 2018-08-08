using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowRegisterService : ServiceBase<S_FlowRegister>
    {
       
    }

    public class S_FlowRegister : ModelBase
    {

        [Identity]
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
