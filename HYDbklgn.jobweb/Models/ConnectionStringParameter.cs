﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HYDbklgn.jobweb.Models
{
    public class ConnectionStringParameter : NamedParameter
    {
        public ConnectionStringParameter(string connectionString) : base("connectionString", connectionString)
        {

        }

        public static ConnectionStringParameter Create()
        {
            return new ConnectionStringParameter(HYDbklgn.Framework.Model.Builder.CreateString());
        }
    }
}