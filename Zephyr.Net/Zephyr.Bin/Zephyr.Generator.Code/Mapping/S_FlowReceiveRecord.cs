using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_FlowReceiveRecordMapping : EntityTypeConfiguration<S_FlowReceiveRecord>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public S_FlowReceiveRecordMapping()
        {
            ToTable("S_FlowReceiveRecord");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
