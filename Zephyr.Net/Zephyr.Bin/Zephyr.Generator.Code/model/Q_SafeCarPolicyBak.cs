using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SafeCarPolicyBak : IAggregateRoot
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
