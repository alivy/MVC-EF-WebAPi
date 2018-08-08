using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_PicService : ServiceBase<Q_Pic>
    {
       
    }

    public class Q_Pic : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string PicUrl{ get; set; }
        public int Type{ get; set; }
        public string Title{ get; set; }
        public int ProType{ get; set; }
        public int SubjectPayId{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
