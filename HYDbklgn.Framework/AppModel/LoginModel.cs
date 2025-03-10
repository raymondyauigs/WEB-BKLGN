using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYDbklgn.Framework.AppModel
{
    public class LoginModel
    {
        public string account { get; set; }
        public string password { get; set; }
        public string returnUrl { get; set; }
    }
}