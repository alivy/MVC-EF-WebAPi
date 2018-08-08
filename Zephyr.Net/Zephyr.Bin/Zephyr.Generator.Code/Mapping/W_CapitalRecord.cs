using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class W_CapitalRecordMapping : EntityTypeConfiguration<W_CapitalRecord>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public W_CapitalRecordMapping()
        {
            ToTable("W_CapitalRecord");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
