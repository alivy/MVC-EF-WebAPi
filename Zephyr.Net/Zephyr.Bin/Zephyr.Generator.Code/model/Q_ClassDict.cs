using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ClassDict : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Name{ get; set; }
        public int ParentId{ get; set; }
        public int Depth{ get; set; }
        public string Path{ get; set; }
        public int OrderNo{ get; set; }
        public string Remark{ get; set; }
        public DateTime AddTime{ get; set; }
        public int Status{ get; set; }
    }
}
