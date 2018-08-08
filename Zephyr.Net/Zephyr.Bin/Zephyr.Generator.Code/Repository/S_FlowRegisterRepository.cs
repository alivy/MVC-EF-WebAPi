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
    public class S_FlowRegisterRepository : BaseRepository<S_FlowRegister>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public S_FlowRegisterRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

