using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SubJectRepaySignService : ServiceBase<Q_SubJectRepaySign>
    {
       
    }

    public class Q_SubJectRepaySign : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public decimal? Add_SignAmount{ get; set; }
        public decimal? Make_SignAmount{ get; set; }
        public decimal? Total_SignAmount{ get; set; }
        public DateTime? Repayment_start_time{ get; set; }
        public DateTime? Repayment_end_time{ get; set; }
        public int? IsDel{ get; set; }
        public DateTime? Addtime{ get; set; }
        public int sign_flag{ get; set; }
        public string Sign_Order{ get; set; }
    }
}
