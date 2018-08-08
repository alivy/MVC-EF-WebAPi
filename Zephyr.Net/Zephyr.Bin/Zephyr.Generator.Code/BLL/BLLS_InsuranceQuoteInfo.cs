using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_InsuranceQuoteInfoBLL : BaseBLL<S_InsuranceQuoteInfo>
    {
        public S_InsuranceQuoteInfoDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_InsuranceQuoteInfoDal();
        }      
    }
}
