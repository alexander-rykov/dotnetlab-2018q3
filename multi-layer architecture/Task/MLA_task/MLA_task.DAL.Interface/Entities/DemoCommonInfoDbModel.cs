using System.Collections.Generic;

namespace MLA_task.DAL.Interface.Entities
{
    public class DemoCommonInfoDbModel
    {
        public int Id { get; set; }
        public string CommonInfo { get; set; }
        public virtual ICollection<DemoDbModel> DemoModels { get; set; }
    }
}