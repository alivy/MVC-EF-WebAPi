using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_QuMapping : EntityTypeConfiguration<Q_Qu>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_QuMapping()
        {
            ToTable("Q_Qu");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
