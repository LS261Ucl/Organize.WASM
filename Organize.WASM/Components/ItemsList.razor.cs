using Microsoft.AspNetCore.Components;
using Organize.Shared.Contracts;
using Organize.Shared.Enitites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Organize.WASM.Components
{
    public partial class ItemsList: ComponentBase
    {
        [Inject]
        private IcurrentUserService CurrentUserService { get; set; }

        protected ObservableCollection<BaseItem> UserItems { get; set; } = new ObservableCollection<BaseItem>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            UserItems = CurrentUserService.CurrentUser.UserItems;
        }
    }
}
