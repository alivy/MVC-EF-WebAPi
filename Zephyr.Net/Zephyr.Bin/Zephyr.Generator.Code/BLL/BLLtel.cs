using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class telBLL : BaseBLL<tel>
    {
        public telDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new telDal();
        }      
    }
}
