using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_InsuranceDelivery_bakBLL : BaseBLL<S_InsuranceDelivery_bak>
    {
        public S_InsuranceDelivery_bakDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_InsuranceDelivery_bakDal();
        }      
    }
}
