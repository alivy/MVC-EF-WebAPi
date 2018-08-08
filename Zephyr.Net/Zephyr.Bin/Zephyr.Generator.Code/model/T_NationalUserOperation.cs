using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_NationalUserOperationService : ServiceBase<T_NationalUserOperation>
    {
       
    }

    public class T_NationalUserOperation : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public string MyProvince{ get; set; }
        public string MyCity{ get; set; }
        public string MyAddress{ get; set; }
        public string MypointX{ get; set; }
        public string MypointY{ get; set; }
        public string HomeProvince{ get; set; }
        public string HomeCity{ get; set; }
        public string HomeAddress{ get; set; }
        public string HomepointX{ get; set; }
        public string HomepointY{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? VisitNumStutas{ get; set; }
    }
}
