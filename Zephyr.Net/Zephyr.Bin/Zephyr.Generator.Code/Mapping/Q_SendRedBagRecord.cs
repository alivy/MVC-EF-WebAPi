using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SendRedBagRecordMapping : EntityTypeConfiguration<Q_SendRedBagRecord>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_SendRedBagRecordMapping()
        {
            ToTable("Q_SendRedBagRecord");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
