using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Pulse : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public int Num{ get; set; }
        public DateTime AddTime{ get; set; }
        public string desc{ get; set; }
        public int IsReset{ get; set; }
        public DateTime UpdateTime{ get; set; }
    }
}
