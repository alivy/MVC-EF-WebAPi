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
    /// 投资项目仓储
    /// </summary>
    public class S_InsuranceQuoteInfo_bakRepository : BaseRepository<S_InsuranceQuoteInfo_bak>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public S_InsuranceQuoteInfo_bakRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

