using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_InsuranceQuoteRiskInfoBLL : BaseBLL<S_InsuranceQuoteRiskInfo>
    {
        public S_InsuranceQuoteRiskInfoDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_InsuranceQuoteRiskInfoDal();
        }      
    }
}
