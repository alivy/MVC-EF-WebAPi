using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_ActivityOperationService : ServiceBase<T_ActivityOperation>
    {
       
    }

    public class T_ActivityOperation : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public int? ActivityNO{ get; set; }
        public DateTime? InTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? ClickNum{ get; set; }
        public string Patriotic{ get; set; }
        public int? EntryStyle{ get; set; }
    }
}
