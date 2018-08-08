using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_InsuranceRelationService : ServiceBase<S_InsuranceRelation>
    {
       
    }

    public class S_InsuranceRelation : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderNumber{ get; set; }
        public int? RelationType{ get; set; }
        public string IdType{ get; set; }
        public string TrueName{ get; set; }
        public string IdNo{ get; set; }
        public string Phone{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Email{ get; set; }
    }
}
