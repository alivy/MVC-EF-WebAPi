using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class W_CapitalRecord : IAggregateRoot
    {

        [PrimaryKey]
        public int id{ get; set; }
        public int WId{ get; set; }
        public string UserName{ get; set; }
        public string FullName{ get; set; }
        public int UserId{ get; set; }
        public decimal TotalNum{ get; set; }
        public decimal EnableNum{ get; set; }
        public decimal DiffNum{ get; set; }
        public DateTime LastTime{ get; set; }
        public int LastId{ get; set; }
        public int TypeId{ get; set; }
        public string Remark{ get; set; }
        public int State{ get; set; }
    }
}
