using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CapitaExtraction : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string BankName{ get; set; }
        public string BankBranchName{ get; set; }
        public string BankNum{ get; set; }
        public decimal MoneyNum{ get; set; }
        public decimal AccountNum{ get; set; }
        public decimal Poundage{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public string OrderNumber{ get; set; }
        public string IpsNumber{ get; set; }
        public string SerialNumber{ get; set; }
        public int QueryNum{ get; set; }
        public int IsBankAccount{ get; set; }
        public string Order_ID{ get; set; }
    }
}
