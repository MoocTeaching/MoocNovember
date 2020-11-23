using Autofac;
using Mooc.DataAccess.Context;
using Mooc.DataAccess.Service;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace Mooc.Web.Tests
{
    public static class AutofacConfigHelper
    {
        static IContainer _build;
        static AutofacConfigHelper()
        {
            var builder = new ContainerBuilder();

            var baseType = typeof(IDependency);
            builder.RegisterType<DataContext>().AsSelf().InstancePerLifetimeScope();
            //var assemblys = BuildManager.GetReferencedAssemblies().Cast<Assembly>();
            var assemblys = new Assembly[] { baseType.Assembly };
            builder.RegisterAssemblyTypes(assemblys.ToArray()).Where(t => baseType.IsAssignableFrom(t) && t != baseType).AsImplementedInterfaces().InstancePerLifetimeScope();

            _build = builder.Build();
        }


        public static T ResolveServcie<T>()
        {
            if (_build == null)
                return default(T);

            return _build.Resolve<T>();
        }
    }
}
