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
    public class S_FlowRewardConfigRepository : BaseRepository<S_FlowRewardConfig>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public S_FlowRewardConfigRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

