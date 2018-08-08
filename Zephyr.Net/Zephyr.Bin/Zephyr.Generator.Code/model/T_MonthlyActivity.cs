using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MonthlyActivity : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? StartTime{ get; set; }
        public DateTime? EndTime{ get; set; }
        public string Remark{ get; set; }
        public int? ActivityTypeId{ get; set; }
        public int IsWork{ get; set; }
    }
}
