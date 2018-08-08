using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BankRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public string FullName{ get; set; }
        public string BankName{ get; set; }
        public string BankBranchName{ get; set; }
        public string OldBankNum{ get; set; }
        public string BankNum{ get; set; }
        public int? BankType{ get; set; }
        public string Province{ get; set; }
        public string City{ get; set; }
        public DateTime? Addtime{ get; set; }
        public int? State{ get; set; }
        public string Out_Serial_No{ get; set; }
        public string Order_Id{ get; set; }
    }
}
