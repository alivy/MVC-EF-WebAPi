using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_JoinPosition : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string JobName{ get; set; }
        public string JobReq{ get; set; }
        public string PositionDesc{ get; set; }
        public int HiringNum{ get; set; }
        public int DeptId{ get; set; }
        public int IsDel{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
