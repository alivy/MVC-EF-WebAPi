using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowRewardForRegisterConfigMapping : EntityTypeConfiguration<S_FlowRewardForRegisterConfig>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public S_FlowRewardForRegisterConfigMapping()
        {
            ToTable("S_FlowRewardForRegisterConfig");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
