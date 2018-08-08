using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_SubjectMoneyBackType : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public int? Sort{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
