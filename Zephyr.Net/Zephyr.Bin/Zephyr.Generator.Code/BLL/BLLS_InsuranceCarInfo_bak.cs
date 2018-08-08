using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_InsuranceCarInfo_bakBLL : BaseBLL<S_InsuranceCarInfo_bak>
    {
        public S_InsuranceCarInfo_bakDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_InsuranceCarInfo_bakDal();
        }      
    }
}
