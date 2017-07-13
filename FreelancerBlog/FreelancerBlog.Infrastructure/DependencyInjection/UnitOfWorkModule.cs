﻿using Autofac;
using FreelancerBlog.Core.Repository;
using FreelancerBlog.Data.Repository;

namespace FreelancerBlog.Infrastructure.DependencyInjection
{
    public class UnitOfWorkModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}