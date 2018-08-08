using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_StationMessageService : ServiceBase<Q_StationMessage>
    {
       
    }

    public class Q_StationMessage : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string From{ get; set; }
        public string To{ get; set; }
        public string Title{ get; set; }
        public string Content{ get; set; }
        public int? SendState{ get; set; }
        public int? ReceiveState{ get; set; }
        public int ReadState{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? ReadTime{ get; set; }
        public int ToId{ get; set; }
    }
}
