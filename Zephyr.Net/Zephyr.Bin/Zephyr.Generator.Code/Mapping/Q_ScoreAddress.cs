using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ScoreAddressMapping : EntityTypeConfiguration<Q_ScoreAddress>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_ScoreAddressMapping()
        {
            ToTable("Q_ScoreAddress");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
