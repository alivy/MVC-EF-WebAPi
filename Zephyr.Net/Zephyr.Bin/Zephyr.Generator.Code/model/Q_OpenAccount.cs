using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_OpenAccount : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string FullName{ get; set; }
        public string IdType{ get; set; }
        public string CardNum{ get; set; }
        public string MoblieNum{ get; set; }
        public string BankNum{ get; set; }
        public string ReserveMoblieNum{ get; set; }
        public string EnableNum{ get; set; }
        public string OpenTerm{ get; set; }
        public int? AccountState{ get; set; }
        public string OpenStyle{ get; set; }
        public string OpenEnableNum{ get; set; }
        public string BindNumber{ get; set; }
        public string CustomerNo{ get; set; }
        public string AccountID{ get; set; }
        public string HandState{ get; set; }
    }
}
