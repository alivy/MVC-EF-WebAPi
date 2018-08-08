using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ActionUrlService : ServiceBase<Q_ActionUrl>
    {
       
    }

    public class Q_ActionUrl : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string actionGroup{ get; set; }
        public string actionDescription{ get; set; }
        public string actionUrl{ get; set; }
        public DateTime addTime{ get; set; }
    }
}
