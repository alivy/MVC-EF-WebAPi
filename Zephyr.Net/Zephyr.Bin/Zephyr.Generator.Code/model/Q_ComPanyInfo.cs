using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ComPanyInfoService : ServiceBase<Q_ComPanyInfo>
    {
       
    }

    public class Q_ComPanyInfo : ModelBase
    {

        [PrimaryKey]
        public int id{ get; set; }
        public string ContactPerson{ get; set; }
        public string ContactPhone{ get; set; }
        public string LicenseNumber{ get; set; }
        public string RegistrationNumber{ get; set; }
        public string Desc{ get; set; }
        public int? State{ get; set; }
        public int? OperatorId{ get; set; }
        public DateTime? OperatorTime{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
