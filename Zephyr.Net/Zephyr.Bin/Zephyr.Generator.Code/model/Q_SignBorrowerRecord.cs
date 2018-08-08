using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SignBorrowerRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? Uid{ get; set; }
        public string card_no{ get; set; }
        public decimal? payment_amount{ get; set; }
        public decimal? repayment_amount{ get; set; }
        public string out_serial_no{ get; set; }
        public string payment_start_time{ get; set; }
        public string repayment_start_time{ get; set; }
        public string payment_end_time{ get; set; }
        public string repayment_end_time{ get; set; }
        public DateTime? Addtime{ get; set; }
        public int sign_flag{ get; set; }
    }
}
