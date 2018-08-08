using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Capital_20180629 : IAggregateRoot
    {

        [Identity]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public decimal Total{ get; set; }
        public decimal Wait{ get; set; }
        public decimal Lock{ get; set; }
        public decimal EnableNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
