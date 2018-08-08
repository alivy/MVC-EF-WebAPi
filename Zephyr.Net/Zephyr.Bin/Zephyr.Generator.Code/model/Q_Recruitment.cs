using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Recruitment : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string FullName{ get; set; }
        public string Mobile{ get; set; }
        public string Email{ get; set; }
        public string Position{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
