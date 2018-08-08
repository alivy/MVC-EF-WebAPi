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
    public class F_ContractRepository : BaseRepository<F_Contract>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public F_ContractRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

