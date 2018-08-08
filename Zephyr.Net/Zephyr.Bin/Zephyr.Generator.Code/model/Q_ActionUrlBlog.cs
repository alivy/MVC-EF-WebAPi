using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ActionUrlBlogService : ServiceBase<Q_ActionUrlBlog>
    {
       
    }

    public class Q_ActionUrlBlog : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string userAddress{ get; set; }
        public int actionId{ get; set; }
        public DateTime addTime{ get; set; }
    }
}
