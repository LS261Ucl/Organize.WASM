using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize.Shared.Enitites
{
  public class ParentItem : BaseItem
    {
        public ObservableCollection<ChildItem> ChildItems { get; set; }
    }
}
