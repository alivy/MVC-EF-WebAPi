using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_StationMessageMapping : EntityTypeConfiguration<Q_StationMessage>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_StationMessageMapping()
        {
            ToTable("Q_StationMessage");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
