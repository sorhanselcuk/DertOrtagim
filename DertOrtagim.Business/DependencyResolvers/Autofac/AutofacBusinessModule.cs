using Autofac;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ManagerLoads(builder);
            EntityFrameworkLoads(builder);
            UtilitiesLoads(builder);
            ExternelResourcesLoad(builder);

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }

        private void ExternelResourcesLoad(ContainerBuilder builder)
        {
           
        }

        private void UtilitiesLoads(ContainerBuilder builder)
        {
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }

        private void EntityFrameworkLoads(ContainerBuilder builder)
        {
        }

        private void ManagerLoads(ContainerBuilder builder)
        {
        }
    }
}
