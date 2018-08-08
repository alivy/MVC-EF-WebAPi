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
    public class F_ContractFilingRepository : BaseRepository<F_ContractFiling>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public F_ContractFilingRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

