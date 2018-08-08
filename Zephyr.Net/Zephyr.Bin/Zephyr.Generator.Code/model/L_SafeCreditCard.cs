using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_SafeCreditCardService : ServiceBase<L_SafeCreditCard>
    {
       
    }

    public class L_SafeCreditCard : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public string CreditCardNum{ get; set; }
        public string ValidYear{ get; set; }
        public string ValidMonth{ get; set; }
        public string AuthCode{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime AuthTime{ get; set; }
        public int IsDel{ get; set; }
        public int State{ get; set; }
    }
}
