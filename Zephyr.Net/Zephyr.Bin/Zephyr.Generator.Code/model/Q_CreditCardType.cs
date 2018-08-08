using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditCardTypeService : ServiceBase<Q_CreditCardType>
    {
       
    }

    public class Q_CreditCardType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public DateTime AddTime{ get; set; }
        public int Sorts{ get; set; }
        public string LV{ get; set; }
        public decimal? LimitAmount{ get; set; }
        public decimal? CAccount{ get; set; }
        public string Abbreviation{ get; set; }
        public string BankLV{ get; set; }
        public decimal? BankLimitAmount{ get; set; }
        public decimal? BankAccount{ get; set; }
        public string FeeLV{ get; set; }
        public int IsDel{ get; set; }
    }
}
