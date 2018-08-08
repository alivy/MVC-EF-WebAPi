using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ConsultantDept_User : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int DeptId{ get; set; }
        public int Consultant{ get; set; }
        public int IsDel{ get; set; }
        public int IsMana{ get; set; }
        public int Sort{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
