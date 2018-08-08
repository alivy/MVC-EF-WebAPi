using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UserInfoService : ServiceBase<Q_UserInfo>
    {
       
    }

    public class Q_UserInfo : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string UserName{ get; set; }
        public int DelFlag{ get; set; }
        public int Gender{ get; set; }
        public int Age{ get; set; }
        public string Email{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Password{ get; set; }
        public string TrueName{ get; set; }
        public string OfficeTel{ get; set; }
        public string OfficeQQ{ get; set; }
        public string WeiXinOpenID{ get; set; }
        public string WeiXinUser{ get; set; }
        public string Mobile{ get; set; }
        public string SelfRating{ get; set; }
        public int? UserState{ get; set; }
        public string HeadPic{ get; set; }
        public string ChildUid{ get; set; }
        public DateTime UpdateTime{ get; set; }
        public int FailNum{ get; set; }
        public DateTime? LockTime{ get; set; }
        public int IsLimits{ get; set; }
    }
}
