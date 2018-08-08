using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BannerService : ServiceBase<Q_Banner>
    {
       
    }

    public class Q_Banner : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string title{ get; set; }
        public int? bannerType{ get; set; }
        public int? bannerPosition{ get; set; }
        public string imgUrl{ get; set; }
        public string linkUrl{ get; set; }
        public int? isActivity{ get; set; }
        public int? orderNum{ get; set; }
        public int? isWork{ get; set; }
        public DateTime? workStartTime{ get; set; }
        public DateTime? workEndTime{ get; set; }
        public DateTime? addTime{ get; set; }
        public string activityImgUrl{ get; set; }
        public string homeImgUrl{ get; set; }
    }
}
