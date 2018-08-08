using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditoSubjectPayService : ServiceBase<Q_CreditoSubjectPay>
    {
       
    }

    public class Q_CreditoSubjectPay : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string CreditoLoadNumber{ get; set; }
        public string LoanNumber{ get; set; }
        public decimal FloatNum{ get; set; }
        public decimal FeeNum{ get; set; }
    }
}
