using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeCarPolicyBakService : ServiceBase<Q_SafeCarPolicyBak>
    {
       
    }

    public class Q_SafeCarPolicyBak : ModelBase
    {

        public string OrderId{ get; set; }
        public string ApplyPolicyNo{ get; set; }
        public string PolicyNo{ get; set; }
        public string Category{ get; set; }
        public string Remark{ get; set; }
        public int? PolicyStatus{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
