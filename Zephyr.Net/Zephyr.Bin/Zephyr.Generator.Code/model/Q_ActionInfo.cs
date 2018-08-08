using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ActionInfoService : ServiceBase<Q_ActionInfo>
    {
       
    }

    public class Q_ActionInfo : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string ControllerName{ get; set; }
        public string ActionName{ get; set; }
        public int HttpMethod{ get; set; }
        public string Remark{ get; set; }
        public int DelFlag{ get; set; }
        public bool IsMenu{ get; set; }
        public DateTime AddTime{ get; set; }
        public int Sort{ get; set; }
        public string Code{ get; set; }
        public int? ParentId{ get; set; }
    }
}
