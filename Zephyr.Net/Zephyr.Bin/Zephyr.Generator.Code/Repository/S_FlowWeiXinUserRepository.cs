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
    public class S_FlowWeiXinUserRepository : BaseRepository<S_FlowWeiXinUser>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public S_FlowWeiXinUserRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

