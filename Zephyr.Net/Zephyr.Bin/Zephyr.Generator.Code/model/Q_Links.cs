using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Links : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string Url{ get; set; }
        public int Type{ get; set; }
        public string Pic{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public int? Class{ get; set; }
    }
}
