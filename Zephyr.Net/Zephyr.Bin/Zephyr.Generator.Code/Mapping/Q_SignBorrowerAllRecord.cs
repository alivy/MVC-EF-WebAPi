using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SignBorrowerAllRecordMapping : EntityTypeConfiguration<Q_SignBorrowerAllRecord>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public Q_SignBorrowerAllRecordMapping()
        {
            ToTable("Q_SignBorrowerAllRecord");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
