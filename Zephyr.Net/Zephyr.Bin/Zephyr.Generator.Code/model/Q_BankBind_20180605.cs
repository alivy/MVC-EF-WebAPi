using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BankBind_20180605Service : ServiceBase<Q_BankBind_20180605>
    {
       
    }

    public class Q_BankBind_20180605 : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public int? Uid{ get; set; }
        public string FullName{ get; set; }
        public string BankName{ get; set; }
        public string BankBranchName{ get; set; }
        public string BankNum{ get; set; }
        public int? BankType{ get; set; }
        public string Province{ get; set; }
        public string City{ get; set; }
        public int IsATM{ get; set; }
        public int IsDel{ get; set; }
        public DateTime? Addtime{ get; set; }
        public DateTime? UpTime{ get; set; }
        public int? AccountType{ get; set; }
    }
}
