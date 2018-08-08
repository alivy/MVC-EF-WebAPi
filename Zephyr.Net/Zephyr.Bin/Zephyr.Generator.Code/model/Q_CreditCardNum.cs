using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditCardNumService : ServiceBase<Q_CreditCardNum>
    {
       
    }

    public class Q_CreditCardNum : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public decimal? TotalAmount{ get; set; }
        public decimal? TotalAmount2{ get; set; }
        public decimal? TotalAmount3{ get; set; }
        public decimal? TotalAmount4{ get; set; }
        public decimal? TotalSum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public decimal? TotalAmount5{ get; set; }
        public decimal? TotalAmount6{ get; set; }
    }
}
