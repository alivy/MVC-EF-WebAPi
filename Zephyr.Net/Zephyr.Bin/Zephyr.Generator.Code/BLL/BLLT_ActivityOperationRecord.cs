using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class T_ActivityOperationRecordBLL : BaseBLL<T_ActivityOperationRecord>
    {
        public T_ActivityOperationRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new T_ActivityOperationRecordDal();
        }      
    }
}
