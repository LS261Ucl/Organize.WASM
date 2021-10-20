using Organize.Shared.Enums;

namespace Organize.Shared.Enitites
{
   public class BaseItem: BaseEntity
   {
        public int ParentId { get; set; }
        public ItemTypeEnum ItemTypeEnum { get; set; }
        public int Position { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }
    }
}
