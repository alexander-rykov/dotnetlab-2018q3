using System.Data.Entity;

namespace MLA_task.EF
{
    public class DemoContext : DbContext
    {
        public DemoContext()
        {
            Database.SetInitializer(new DbInitializer());
        }

        public IDbSet<DemoModel> DemoDbModels { get; set; }
        public IDbSet<DemoCommonInfoModel> DemoCommonInfoModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DemoDbModelConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}