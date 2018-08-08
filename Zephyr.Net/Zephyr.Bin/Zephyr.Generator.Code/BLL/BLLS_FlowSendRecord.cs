using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_FlowSendRecordBLL : BaseBLL<S_FlowSendRecord>
    {
        public S_FlowSendRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_FlowSendRecordDal();
        }      
    }
}
