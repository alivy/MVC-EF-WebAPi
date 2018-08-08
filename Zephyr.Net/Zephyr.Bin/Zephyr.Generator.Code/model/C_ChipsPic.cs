using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class C_ChipsPic : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int ChipsId{ get; set; }
        public string ChipsNumber{ get; set; }
        public string PicUrl{ get; set; }
        public string Title{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
