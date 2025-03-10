using HYDbklgn.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using HYDbklgn.Abstraction;
using BootstrapTable.Pager;
using HYDbklgn.Framework.AppModel;

namespace HYDbklgn.jobweb.AppModels
{
    public class QySettingModel : QuerySettingModel
    {
        public IPager<IEditSettingModel> Records { get; set; }
    }

    public class QyUserModel: QueryUserModel
    {

        public IPager<IEditUserModel> Records { get; set; }

    }

    

}