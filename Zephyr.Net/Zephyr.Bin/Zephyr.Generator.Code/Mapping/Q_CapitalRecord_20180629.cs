using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CapitalRecord_20180629Mapping : EntityTypeConfiguration<Q_CapitalRecord_20180629>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_CapitalRecord_20180629Mapping()
        {
            ToTable("Q_CapitalRecord_20180629");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
