using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_InsuranceRelation_bakBLL : BaseBLL<S_InsuranceRelation_bak>
    {
        public S_InsuranceRelation_bakDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_InsuranceRelation_bakDal();
        }      
    }
}
