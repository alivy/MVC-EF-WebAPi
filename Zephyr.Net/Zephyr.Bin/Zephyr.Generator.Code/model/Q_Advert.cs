using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AdvertService : ServiceBase<Q_Advert>
    {
       
    }

    public class Q_Advert : ModelBase
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public string Title{ get; set; }
        public DateTime? BeginDate{ get; set; }
        public DateTime? EndDate{ get; set; }
        public string Url{ get; set; }
        public int? ClickNum{ get; set; }
        public int? UserID{ get; set; }
        public string UserName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int AdvertClassId{ get; set; }
        public string Remark{ get; set; }
        public string PicPath{ get; set; }
    }
}
