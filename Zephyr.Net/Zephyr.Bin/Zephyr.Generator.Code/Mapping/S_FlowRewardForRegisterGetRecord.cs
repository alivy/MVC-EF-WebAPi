using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowRewardForRegisterGetRecordMapping : EntityTypeConfiguration<S_FlowRewardForRegisterGetRecord>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public S_FlowRewardForRegisterGetRecordMapping()
        {
            ToTable("S_FlowRewardForRegisterGetRecord");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
