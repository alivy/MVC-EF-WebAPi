using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Department : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string DeptName{ get; set; }
        public int DelFlag{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Remark{ get; set; }
    }
}
