using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeOrderImgService : ServiceBase<Q_SafeOrderImg>
    {
       
    }

    public class Q_SafeOrderImg : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderId{ get; set; }
        public string ImgUrl1{ get; set; }
        public string ImgUrl2{ get; set; }
        public string ImgUrl3{ get; set; }
        public string ImgUrl4{ get; set; }
        public string ImgUrl5{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
