using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SafeMoblieBind_20180612 : IAggregateRoot
    {

        [Identity]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string MoblieNum{ get; set; }
        public int State{ get; set; }
        public int IsDel{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? UpTime{ get; set; }
    }
}
