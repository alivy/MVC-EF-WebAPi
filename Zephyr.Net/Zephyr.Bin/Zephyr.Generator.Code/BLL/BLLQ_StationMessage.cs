using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_StationMessageBLL : BaseBLL<Q_StationMessage>
    {
        public Q_StationMessageDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_StationMessageDal();
        }      
    }
}
