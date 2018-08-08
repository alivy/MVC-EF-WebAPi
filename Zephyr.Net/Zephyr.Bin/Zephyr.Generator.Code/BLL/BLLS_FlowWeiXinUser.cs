using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_FlowWeiXinUserBLL : BaseBLL<S_FlowWeiXinUser>
    {
        public S_FlowWeiXinUserDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_FlowWeiXinUserDal();
        }      
    }
}
