using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ArticleClassService : ServiceBase<Q_ArticleClass>
    {
       
    }

    public class Q_ArticleClass : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ClassName{ get; set; }
        public int? ParentID{ get; set; }
        public int? OrderID{ get; set; }
        public string PageTitle{ get; set; }
        public string PageKeyWord{ get; set; }
        public string PageDescription{ get; set; }
        public SByte? PageType{ get; set; }
        public int? SiteID{ get; set; }
        public SByte? SiteType{ get; set; }
        public string FolderName{ get; set; }
        public string TemplatePath{ get; set; }
    }
}
