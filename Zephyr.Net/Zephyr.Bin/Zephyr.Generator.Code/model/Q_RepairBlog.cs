using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RepairBlogService : ServiceBase<Q_RepairBlog>
    {
       
    }

    public class Q_RepairBlog : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Content{ get; set; }
        public int? State{ get; set; }
        public string UserName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Type{ get; set; }
    }
}
