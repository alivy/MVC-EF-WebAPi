using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CaptchaRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Mobile{ get; set; }
        public string Code{ get; set; }
        public int ErrorCount{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public string AddIp{ get; set; }
        public string ValidateIp{ get; set; }
        public int Category{ get; set; }
    }
}
