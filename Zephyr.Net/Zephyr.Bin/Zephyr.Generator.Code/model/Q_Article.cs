using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ArticleService : ServiceBase<Q_Article>
    {
       
    }

    public class Q_Article : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string ArticleContent{ get; set; }
        public string CoreContent{ get; set; }
        public string Keyword{ get; set; }
        public bool? IsCommend{ get; set; }
        public int? VisitCount{ get; set; }
        public int? ClassID{ get; set; }
        public int? UserID{ get; set; }
        public string UserName{ get; set; }
        public int? EditorID{ get; set; }
        public string EditorName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? EditTime{ get; set; }
        public SByte? SiteType{ get; set; }
        public string LargeIcon{ get; set; }
        public string LittleIcon{ get; set; }
    }
}
