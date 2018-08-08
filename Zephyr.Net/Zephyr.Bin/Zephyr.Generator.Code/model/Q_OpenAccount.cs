using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_OpenAccountService : ServiceBase<Q_OpenAccount>
    {
       
    }

    public class Q_OpenAccount : ModelBase
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
