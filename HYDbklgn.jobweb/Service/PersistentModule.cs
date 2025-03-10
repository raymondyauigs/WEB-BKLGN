using Autofac;
using HYDbklgn.Abstraction;
using HYDbklgn.Service;
using HYDbklgn.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using Microsoft.Extensions.Caching.Memory;
using HYDbklgn.Framework.AppModel;
using HYDbklgn.jobweb.Models;

namespace HYDbklgn.jobweb.Service
{
    public class PersistentModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterInstance(new MemoryCache(new MemoryCacheOptions())).As<IMemoryCache>().SingleInstance();
            builder.RegisterInstance(EditModels.Default).As<EditModels>().SingleInstance();
            builder.RegisterType<ErrorLog>().As<IErrorLog>().InstancePerLifetimeScope();
            builder.RegisterType<MiscLog>().As<IMiscLog>().InstancePerLifetimeScope();
            builder.RegisterType<StdbLog>().As<IStdbLog>().InstancePerLifetimeScope();            
            builder.RegisterType<HYDbklgnEntities>().WithParameter(ConnectionStringParameter.Create()).InstancePerLifetimeScope();
            builder.RegisterType<SettingsService>().As<ISettingService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();


        }
    }
}