using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SignBorrowerAllRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? Uid{ get; set; }
        public string AccountID{ get; set; }
        public decimal? Amount{ get; set; }
        public string Out_serial_no{ get; set; }
        public string Start_time{ get; set; }
        public string End_time{ get; set; }
        public DateTime? Addtime{ get; set; }
        public int? Sign_flag{ get; set; }
        public string Interface_type{ get; set; }
    }
}
