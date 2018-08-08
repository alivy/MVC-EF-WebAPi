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
    public class P_LoanApplyBagRepository : BaseRepository<P_LoanApplyBag>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public P_LoanApplyBagRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

