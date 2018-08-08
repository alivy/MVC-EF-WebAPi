using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_AppUpdateRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string VersionCode{ get; set; }
        public string VersionName{ get; set; }
        public string PackageSize{ get; set; }
        public string UpdateContent{ get; set; }
        public string DownloadUrl{ get; set; }
        public int APPTypeId{ get; set; }
        public int UserID{ get; set; }
        public string UserName{ get; set; }
        public int? EditorID{ get; set; }
        public string EditorName{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? EditTime{ get; set; }
        public string TrueUrl{ get; set; }
    }
}
