using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_LoanPersonalContacts : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public string ContactsName{ get; set; }
        public string ContactsRelation{ get; set; }
        public string ContactsPhone{ get; set; }
        public DateTime AddTime{ get; set; }
        public int IsDel{ get; set; }
    }
}
