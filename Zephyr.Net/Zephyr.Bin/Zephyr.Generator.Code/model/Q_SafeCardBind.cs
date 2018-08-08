using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SafeCardBind : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string FullName{ get; set; }
        public string CardNum{ get; set; }
        public string Birthday{ get; set; }
        public int Sex{ get; set; }
        public int State{ get; set; }
        public int IsDel{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? UpTime{ get; set; }
        public string Customer_ID{ get; set; }
        public int? AccountType{ get; set; }
    }
}
