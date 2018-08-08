using QFTService.Domain;
using QFTService.Domain.Repository.Interfaces;
using QFTService.DtoModel;
using QFTService.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Repository
{
    /// <summary>
    /// Ͷ����Ŀ�ִ�
    /// </summary>
    public class L_SafeSocialSecurityRepository : BaseRepository<L_SafeSocialSecurity>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public L_SafeSocialSecurityRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

