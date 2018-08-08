using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MonthlyActivityType : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string ActionDay{ get; set; }
        public int? BackType{ get; set; }
        public string Remark{ get; set; }
    }
}
