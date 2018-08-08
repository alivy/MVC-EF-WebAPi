using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_IsRecommendService : ServiceBase<T_IsRecommend>
    {
       
    }

    public class T_IsRecommend : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int UserId{ get; set; }
        public int IsDel{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
