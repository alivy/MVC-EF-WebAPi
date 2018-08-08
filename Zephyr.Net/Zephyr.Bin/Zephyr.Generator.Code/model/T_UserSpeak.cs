using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_UserSpeakService : ServiceBase<T_UserSpeak>
    {
       
    }

    public class T_UserSpeak : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpendId{ get; set; }
        public string NickName{ get; set; }
        public string HeadImg{ get; set; }
        public string Remark{ get; set; }
        public string Sex{ get; set; }
        public string Province{ get; set; }
        public string City{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
