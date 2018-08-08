using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_UpScoreRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string Remark{ get; set; }
        public DateTime SignTime{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
