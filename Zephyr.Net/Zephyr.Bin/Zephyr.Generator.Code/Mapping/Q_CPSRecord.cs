using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CPSRecordMapping : EntityTypeConfiguration<Q_CPSRecord>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_CPSRecordMapping()
        {
            ToTable("Q_CPSRecord");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
