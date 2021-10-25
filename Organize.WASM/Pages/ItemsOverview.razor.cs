using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Organize.WASM.ItemEdit;
using Organize.Shared.Enums;

namespace Organize.WASM.Pages
{
    public partial class ItemsOverview : ComponentBase
    {
        //[Inject]
        //private ItemEditService ItemEditService { get; set; }//using Servicecall

        [Parameter]
        public string TypeString { get; set; }//Using Routing

        [Parameter]
        public int? Id { get; set; }

        private bool ShowEdit { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            //ItemEditService.EditItemChanged += HandleEditItemChanged;
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if(Id != null & Enum.TryParse(typeof(ItemTypeEnum), TypeString, out _))
            {
                ShowEdit = true;
            }
            {
                ShowEdit = false;
            }
        }

        private void HandleEditItemChanged(object sender, ItemEditEventArgs e)
        {
            ShowEdit = e.Item != null;
            StateHasChanged();
        }
    }
}
