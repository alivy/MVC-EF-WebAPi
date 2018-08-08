using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_UserInfoAddress : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public int AddressId{ get; set; }
        public int TypeId{ get; set; }
    }
}
