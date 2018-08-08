using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_SafeSocialSecurityMapping : EntityTypeConfiguration<L_SafeSocialSecurity>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public L_SafeSocialSecurityMapping()
        {
            ToTable("L_SafeSocialSecurity");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
