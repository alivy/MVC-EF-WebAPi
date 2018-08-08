using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SHTradeRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string code{ get; set; }
        public string msg{ get; set; }
        public string service{ get; set; }
        public string timestamp{ get; set; }
        public string uuid{ get; set; }
        public string sign_type{ get; set; }
        public string sign{ get; set; }
        public string encode{ get; set; }
        public string version{ get; set; }
        public string client{ get; set; }
        public string custom{ get; set; }
        public string sequence_id{ get; set; }
        public string card_no{ get; set; }
        public string out_serial_no{ get; set; }
        public string asset_no{ get; set; }
        public string bid_amount{ get; set; }
        public string forcast_income{ get; set; }
        public string prd_issuer{ get; set; }
        public string buy_date{ get; set; }
        public string state{ get; set; }
        public string auth_code{ get; set; }
        public string name{ get; set; }
        public string bonus_amount{ get; set; }
        public string cert_type{ get; set; }
        public string cert_no{ get; set; }
        public string in_card_no{ get; set; }
        public string confirm_date{ get; set; }
        public string confirm_time{ get; set; }
        public string third_custom{ get; set; }
    }
}
