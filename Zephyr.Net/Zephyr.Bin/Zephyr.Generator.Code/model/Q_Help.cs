using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_HelpService : ServiceBase<Q_Help>
    {
       
    }

    public class Q_Help : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Type{ get; set; }
        public string Title{ get; set; }
        public string Content{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
