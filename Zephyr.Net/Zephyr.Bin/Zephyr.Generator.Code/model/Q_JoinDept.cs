using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_JoinDept : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public int IsDel{ get; set; }
        public int Sort{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
