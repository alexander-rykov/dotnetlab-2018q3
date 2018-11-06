using System.Collections.Generic;

namespace MLA_task.EF
{
    public class DemoCommonInfoModel
    {
        public int Id { get; set; }
        public string CommonInfo { get; set; }
        public virtual ICollection<DemoModel> DemoModels { get; set; }
    }
}