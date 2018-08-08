using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RewardGift : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int ProductId{ get; set; }
        public string GiftName{ get; set; }
        public int GiftNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public int OrderNum{ get; set; }
        public int MaxNum{ get; set; }
        public int MinNum{ get; set; }
    }
}
