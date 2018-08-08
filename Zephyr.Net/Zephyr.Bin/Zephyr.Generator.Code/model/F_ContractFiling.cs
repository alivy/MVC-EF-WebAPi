using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class F_ContractFiling : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ContractNo{ get; set; }
        public string Msg{ get; set; }
        public DateTime Addtime{ get; set; }
        public int State{ get; set; }
    }
}
