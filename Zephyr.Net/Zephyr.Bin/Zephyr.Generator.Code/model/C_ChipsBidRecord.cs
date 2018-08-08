using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class C_ChipsBidRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int uid{ get; set; }
        public int ChipsId{ get; set; }
        public string ChipsNumber{ get; set; }
        public string ContractNumber{ get; set; }
        public string InvestOrder{ get; set; }
        public decimal InvestNum{ get; set; }
        public int InvestShare{ get; set; }
        public int InvestType{ get; set; }
        public int InvestState{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
