using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class C_ChipsAttron : IAggregateRoot
    {

        [Identity]
        public int Id{ get; set; }
        public string AttronChipsNumber{ get; set; }
        public string ChipsNumber{ get; set; }
        public decimal FloatNum{ get; set; }
        public decimal FeeNum{ get; set; }
    }
}
