using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Platform : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string FormName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string LinkUrl{ get; set; }
        public int? FormType{ get; set; }
    }
}
