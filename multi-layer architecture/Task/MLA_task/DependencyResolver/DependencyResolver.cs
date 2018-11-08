using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLA_task.BLL;
using MLA_task.BLL.Interface;
using MLA_task.DAL.EF;
using MLA_task.DAL.Interface;
using MLA_task.DAL.Repositories;
using SimpleInjector;

namespace DependencyResolver
{
    public class DependencyResolver
    {
        public static void Resolve(Container container)
        {
            container.Register<DemoContext>();
            container.Register<IDemoDbModelRepository, DemoDbModelRepository>();
            container.Register<IDemoModelService, DemoModelService>();
        }
    }
}
