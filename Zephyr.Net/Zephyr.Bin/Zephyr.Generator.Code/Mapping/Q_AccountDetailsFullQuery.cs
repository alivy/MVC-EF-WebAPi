using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_AccountDetailsFullQueryMapping : EntityTypeConfiguration<Q_AccountDetailsFullQuery>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_AccountDetailsFullQueryMapping()
        {
            ToTable("Q_AccountDetailsFullQuery");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
