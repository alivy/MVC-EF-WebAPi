using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_ComInfoAddress : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int LoanComInfoId{ get; set; }
        public int AddressId{ get; set; }
        public int TypeId{ get; set; }
    }
}
