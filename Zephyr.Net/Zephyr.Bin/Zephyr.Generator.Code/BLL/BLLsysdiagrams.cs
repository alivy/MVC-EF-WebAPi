using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class sysdiagramsBLL : BaseBLL<sysdiagrams>
    {
        public sysdiagramsDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new sysdiagramsDal();
        }      
    }
}
