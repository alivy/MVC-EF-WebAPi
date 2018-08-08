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
    public class C_ChipsSpaceTypeRepository : BaseRepository<C_ChipsSpaceType>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public C_ChipsSpaceTypeRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

