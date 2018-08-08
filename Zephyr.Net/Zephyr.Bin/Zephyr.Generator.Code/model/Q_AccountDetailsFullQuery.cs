using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AccountDetailsFullQueryService : ServiceBase<Q_AccountDetailsFullQuery>
    {
       
    }

    public class Q_AccountDetailsFullQuery : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Bank{ get; set; }
        public string Cardner{ get; set; }
        public decimal? Amount{ get; set; }
        public string Cur_Num{ get; set; }
        public string CrFlag{ get; set; }
        public string ValDate{ get; set; }
        public string InpDate{ get; set; }
        public string RelaDate{ get; set; }
        public string InpTime{ get; set; }
        public string TranNo{ get; set; }
        public string Ori_TranNo{ get; set; }
        public string TransType{ get; set; }
        public string Desline{ get; set; }
        public decimal? Curr_Bal{ get; set; }
        public string Forcardnbr{ get; set; }
        public string Revide{ get; set; }
        public string Resv{ get; set; }
    }
}
