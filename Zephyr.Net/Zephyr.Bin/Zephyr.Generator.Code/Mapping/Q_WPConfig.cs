using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_WPConfigMapping : EntityTypeConfiguration<Q_WPConfig>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_WPConfigMapping()
        {
            ToTable("Q_WPConfig");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
