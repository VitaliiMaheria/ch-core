using Autofac;
using CompHi.CompHiAPI.Core.Services;
using CompHi.Core.Common;
using CompHi.Core.Domain;
using CompHi.DataAccess.Contexts;
using CompHi.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompHi.CompHiAPI
{
    public class CompHiAPIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);


            builder.RegisterType<CompaniesContext>()
                .As<DbContext>()
                .AsSelf()
                .WithParameter("nameOrConnectionString", ConnectionStringsProvider.GetCompaniesConnectionString())
                .InstancePerRequest();

            builder.RegisterType<CompaniesRepository>()
                .As<ICompaniesRepository>()
                .InstancePerRequest();

            builder.RegisterType<CompaniesService>()
                .AsSelf()
                .InstancePerRequest();

        }
    }
}