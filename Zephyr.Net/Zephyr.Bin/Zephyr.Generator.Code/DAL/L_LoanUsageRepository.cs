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
    public class L_LoanUsageRepository : BaseRepository<L_LoanUsage>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public L_LoanUsageRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

