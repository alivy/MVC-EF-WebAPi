using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_AppLog : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? LogType{ get; set; }
        public string LogInfo{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
