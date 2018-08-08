using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeCarPolicyInfoService : ServiceBase<Q_SafeCarPolicyInfo>
    {
       
    }

    public class Q_SafeCarPolicyInfo : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderId{ get; set; }
        public string ApplyPolicyNo{ get; set; }
        public string PolicyNo{ get; set; }
        public string Category{ get; set; }
        public string Remark{ get; set; }
        public int? PolicyStatus{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
