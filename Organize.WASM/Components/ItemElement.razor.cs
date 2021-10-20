﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Organize.Shared.Enitites;

namespace Organize.WASM.Components
{
    public partial class ItemElement<TItem> : ComponentBase where TItem : BaseItem
    {
        [Parameter]
        public TItem Item { get; set; }

        private string DetailAreaId { get; set;}

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            DetailAreaId = "detailArea" + Item.Position;
        }

    }
}
