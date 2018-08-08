using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_CandyRain : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int TypeId{ get; set; }
        public int? RedTypeId{ get; set; }
        public int RedId{ get; set; }
        public int TotalNum{ get; set; }
        public int CurrentNum{ get; set; }
        public int IsLuckyDraw{ get; set; }
        public int IsUsed{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
