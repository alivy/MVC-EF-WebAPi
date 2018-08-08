using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class sysdiagrams : IAggregateRoot
    {

        public string name{ get; set; }
        public int principal_id{ get; set; }
        [Identity]
        [PrimaryKey]
        public int diagram_id{ get; set; }
        public int? version{ get; set; }
        public byte[] definition{ get; set; }
    }
}
