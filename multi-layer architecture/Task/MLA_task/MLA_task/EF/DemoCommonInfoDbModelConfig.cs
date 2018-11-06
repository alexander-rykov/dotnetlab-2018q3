using System.Data.Entity.ModelConfiguration;

namespace MLA_task.EF
{
    public class DemoCommonInfoDbModelConfig : EntityTypeConfiguration<DemoCommonInfoModel>
    {
        public DemoCommonInfoDbModelConfig()
        {
            ToTable("DemoCommonInfoTable");
            HasKey(m => m.Id);
            Property(m => m.CommonInfo).IsRequired().IsUnicode().HasMaxLength(50).IsVariableLength();
        }
    }
}