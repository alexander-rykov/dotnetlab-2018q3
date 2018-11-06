using System.Data.Entity.ModelConfiguration;

namespace MLA_task.EF
{
    public class DemoDbModelConfig : EntityTypeConfiguration<DemoModel>
    {
        public DemoDbModelConfig()
        {
            ToTable("DemoTable");
            HasKey(m => m.Id);
            Property(m => m.Name).IsRequired().IsUnicode().HasMaxLength(35).IsVariableLength();
            Property(m => m.Created).IsRequired();
            Property(m => m.Modified).IsOptional();
            Property(m => m.DemoCommonInfoModelId).IsRequired();
            HasRequired(m => m.DemoCommonInfoModel).WithMany(i => i.DemoModels);
        }
    }
}