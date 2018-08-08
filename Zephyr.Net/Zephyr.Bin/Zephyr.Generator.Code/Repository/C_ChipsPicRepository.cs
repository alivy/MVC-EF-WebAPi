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
    public class C_ChipsPicRepository : BaseRepository<C_ChipsPic>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public C_ChipsPicRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

