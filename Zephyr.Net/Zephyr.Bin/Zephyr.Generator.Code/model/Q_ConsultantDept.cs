using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ConsultantDept : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string DeptName{ get; set; }
        public int? Sort{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
