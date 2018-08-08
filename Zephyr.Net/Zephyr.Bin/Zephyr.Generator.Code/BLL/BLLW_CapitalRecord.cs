using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class W_CapitalRecordBLL : BaseBLL<W_CapitalRecord>
    {
        public W_CapitalRecordDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new W_CapitalRecordDal();
        }      
    }
}
