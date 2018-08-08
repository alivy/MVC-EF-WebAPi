using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_ActivityService : ServiceBase<T_Activity>
    {
       
    }

    public class T_Activity : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? ActivityNO{ get; set; }
        public string ActivityName{ get; set; }
        public DateTime? StatusTime{ get; set; }
        public DateTime? EndTime{ get; set; }
    }
}
