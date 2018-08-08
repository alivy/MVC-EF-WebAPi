using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SecuritySignRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public decimal Add_SignAmount{ get; set; }
        public decimal Make_SignAmount{ get; set; }
        public decimal SignAomount{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? SignType{ get; set; }
    }
}
