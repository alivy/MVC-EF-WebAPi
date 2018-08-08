using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_AnniversaryRedMoney : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public decimal? RedMoney{ get; set; }
        public string Remark{ get; set; }
        public int? State{ get; set; }
        public int? TypeId{ get; set; }
    }
}
