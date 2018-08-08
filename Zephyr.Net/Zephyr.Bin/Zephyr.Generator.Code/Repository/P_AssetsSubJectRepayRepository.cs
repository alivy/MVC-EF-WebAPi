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
    public class P_AssetsSubJectRepayRepository : BaseRepository<P_AssetsSubJectRepay>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public P_AssetsSubJectRepayRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

