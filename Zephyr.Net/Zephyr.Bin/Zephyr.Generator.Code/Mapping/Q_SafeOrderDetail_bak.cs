using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SafeOrderDetail_bakMapping : EntityTypeConfiguration<Q_SafeOrderDetail_bak>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_SafeOrderDetail_bakMapping()
        {
            ToTable("Q_SafeOrderDetail_bak");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
