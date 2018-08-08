using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_PageVisitRecordBLL : BaseBLL<S_PageVisitRecord>
    {
        public S_PageVisitRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_PageVisitRecordDal();
        }      
    }
}
