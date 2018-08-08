using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RedBagActivityService : ServiceBase<Q_RedBagActivity>
    {
       
    }

    public class Q_RedBagActivity : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string Desc{ get; set; }
        public DateTime BeginTime{ get; set; }
        public DateTime EndTime{ get; set; }
        public int Q_RedBagType{ get; set; }
        public int Uid{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public decimal? InvestNum{ get; set; }
        public int? IsGet{ get; set; }
        public int? IsActivity{ get; set; }
        public int? SubjectBidId{ get; set; }
        public string BatchNo{ get; set; }
    }
}
