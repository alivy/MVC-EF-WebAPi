using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BankAccount : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string AccountId{ get; set; }
        public int IsSetPayPwd{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Customer_No{ get; set; }
        public string Serial_No{ get; set; }
        public string Out_Serial_No{ get; set; }
        public string Order_Id{ get; set; }
        public string Account_Type{ get; set; }
    }
}
