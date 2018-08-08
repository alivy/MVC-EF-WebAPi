using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class C_ChipsAttornConfig : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int MinDay{ get; set; }
        public int RaisingPeriod{ get; set; }
        public decimal FeeRate{ get; set; }
        public int PasswordStatus{ get; set; }
    }
}
