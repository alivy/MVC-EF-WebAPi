using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_OperationAge : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int OperationId{ get; set; }
        public int Age{ get; set; }
        public int PeopleCount{ get; set; }
        public decimal InvestTotal{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
