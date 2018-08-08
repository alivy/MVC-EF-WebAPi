using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AccountDetailsQueryService : ServiceBase<Q_AccountDetailsQuery>
    {
       
    }

    public class Q_AccountDetailsQuery : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string AcqCode{ get; set; }
        public string SeqNo{ get; set; }
        public string Cendt{ get; set; }
        public string Cardnbr{ get; set; }
        public decimal? Amount{ get; set; }
        public string CrFlag{ get; set; }
        public string MsgType{ get; set; }
        public string ProcCode{ get; set; }
        public string MerType{ get; set; }
        public string Info{ get; set; }
        public string Term{ get; set; }
        public string RetSeqNo{ get; set; }
        public string ConMode{ get; set; }
        public string Autresp{ get; set; }
        public string ForCode{ get; set; }
        public string ClrDate{ get; set; }
        public string OldSeqno{ get; set; }
        public string OpenBrno{ get; set; }
        public string TranBrno{ get; set; }
        public string Ervind{ get; set; }
        public string TransType{ get; set; }
    }
}
