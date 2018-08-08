using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RewardRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int UserId{ get; set; }
        public int RewardGiftId{ get; set; }
        public string Phone{ get; set; }
        public DateTime AddTime{ get; set; }
        public int IsGet{ get; set; }
        public DateTime? GetTime{ get; set; }
        public int? ContactId{ get; set; }
        public int? OperateId{ get; set; }
        public int? ProductId{ get; set; }
        public string Address{ get; set; }
        public string ContactName{ get; set; }
        public string MoblieNum{ get; set; }
        public string Remark{ get; set; }
        public decimal RewardAmount{ get; set; }
    }
}
