using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Organize.Shared.Enitites;
using Organize.WASM.ItemEdit;

namespace Organize.WASM.Components
{
    public partial class ItemElement<TItem> : ComponentBase where TItem : BaseItem
    {
        [Parameter]
        public RenderFragment MainFragment { get; set; }

        [Parameter]
        public RenderFragment DetailFragment { get; set; }
        [Parameter]
        public TItem Item { get; set; }

        [CascadingParameter]
        public string ColorPrefix { get; set; }

        [CascadingParameter]
        public int TotalNumber { get; set; }

        //[Inject]
        //private ItemEditService ItemEditService { get; set; } metode using service call

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private string DetailAreaId { get; set;}

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            DetailAreaId = "detailArea" + Item.Position;
        }

        private void OpenItemInEditMode()//metode using routing
        {
            //  ItemEditService.EditItem = Item; Metode using service call
            Uri.TryCreate("/items/" + Item.ItemTypeEnum + "/" + Item.Id,
                UriKind.Relative, out var uri);
            NavigationManager.NavigateTo(uri.ToString());
        }

    }
}
