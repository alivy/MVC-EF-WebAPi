using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ScoreLineFreeService : ServiceBase<Q_ScoreLineFree>
    {
       
    }

    public class Q_ScoreLineFree : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string Title{ get; set; }
        public DateTime BeginTime{ get; set; }
        public DateTime EndTime{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? CreditCardId{ get; set; }
        public string OrderNum{ get; set; }
        public decimal? MoneyNum{ get; set; }
        public DateTime? UsedTime{ get; set; }
    }
}
