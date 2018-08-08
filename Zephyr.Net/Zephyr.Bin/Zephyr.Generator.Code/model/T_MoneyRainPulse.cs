using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MoneyRainPulse : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Subjectid{ get; set; }
        public int Num{ get; set; }
        public DateTime AddTime{ get; set; }
        public string desc{ get; set; }
    }
}
