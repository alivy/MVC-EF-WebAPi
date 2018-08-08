using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_InsuranceQuoteInfo_bakBLL : BaseBLL<S_InsuranceQuoteInfo_bak>
    {
        public S_InsuranceQuoteInfo_bakDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_InsuranceQuoteInfo_bakDal();
        }      
    }
}
