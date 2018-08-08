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
    public class P_AssetsSubjectPayRepository : BaseRepository<P_AssetsSubjectPay>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public P_AssetsSubjectPayRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

