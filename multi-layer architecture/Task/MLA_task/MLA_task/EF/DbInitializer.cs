using System.Collections.Generic;
using System.Data.Entity;

namespace MLA_task.EF
{
    public class DbInitializer: CreateDatabaseIfNotExists<DemoContext>
    {
        protected override void Seed(DemoContext context)
        {
            context.DemoCommonInfoModels.Add(new DemoCommonInfoModel { CommonInfo = "Standard 1"});
            context.DemoCommonInfoModels.Add(new DemoCommonInfoModel { CommonInfo = "Standard 2" });
            context.DemoCommonInfoModels.Add(new DemoCommonInfoModel { CommonInfo = "Standard 3"});

            context.DemoDbModels.Add(new DemoModel() { Name = "Demo 1", DemoCommonInfoModelId = 1});
            context.DemoDbModels.Add(new DemoModel() { Name = "Demo 2", DemoCommonInfoModelId = 1 });
            context.DemoDbModels.Add(new DemoModel() { Name = "Demo 3", DemoCommonInfoModelId = 1 });

            context.DemoDbModels.Add(new DemoModel() { Name = "Demo 4", DemoCommonInfoModelId = 2 });
            context.DemoDbModels.Add(new DemoModel() { Name = "Demo 5", DemoCommonInfoModelId = 3 });
            context.DemoDbModels.Add(new DemoModel() { Name = "Demo 6", DemoCommonInfoModelId = 3 });

            base.Seed(context);
        }
    }
}