using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Warning : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Email{ get; set; }
        public int? EState{ get; set; }
        public string Phone{ get; set; }
        public int PState{ get; set; }
        public string UserName{ get; set; }
        public decimal? Amount{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
