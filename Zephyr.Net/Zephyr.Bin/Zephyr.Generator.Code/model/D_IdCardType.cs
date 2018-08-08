using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class D_IdCardType : IAggregateRoot
    {

        public string TypeId{ get; set; }
        public string TypeName{ get; set; }
    }
}
