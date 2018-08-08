using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RiskQuestion : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Question{ get; set; }
        public int? Score1{ get; set; }
        public int? Score2{ get; set; }
        public int? Score3{ get; set; }
        public int? Score4{ get; set; }
        public int? Score5{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
