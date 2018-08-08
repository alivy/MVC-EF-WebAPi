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
    public class P_CompanyAuthRepository : BaseRepository<P_CompanyAuth>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public P_CompanyAuthRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

