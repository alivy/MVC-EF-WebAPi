using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BankEnterpriseService : ServiceBase<Q_BankEnterprise>
    {
       
    }

    public class Q_BankEnterprise : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Cert_No{ get; set; }
        public string Name{ get; set; }
        public string Mobile{ get; set; }
        public string Bind_Card{ get; set; }
        public string Card_No{ get; set; }
        public string Customer_No{ get; set; }
        public string Serial_No{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
