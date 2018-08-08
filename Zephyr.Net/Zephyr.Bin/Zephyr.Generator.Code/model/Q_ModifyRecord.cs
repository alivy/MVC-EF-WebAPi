using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ModifyRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int TypeId{ get; set; }
        public long BatchNo{ get; set; }
        public int RelationId{ get; set; }
        public DateTime AddTime{ get; set; }
        public int DataType{ get; set; }
        public int State{ get; set; }
    }
}
