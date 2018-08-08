using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Advice : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string Desc{ get; set; }
        public string Tel{ get; set; }
        public int? State{ get; set; }
        public int? Uid{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
