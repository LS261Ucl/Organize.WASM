using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Shared.Enitites;

namespace Organize.WASM.Pages
{
    public class SignInBase: SignBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();
        protected string Username { get; set; } = "Lene";

        protected void HandleUserNameChanged(ChangeEventArgs eventArgs)
        {
            Username = eventArgs.Value.ToString();
        }

        protected void HandleUserNameValueChanged(string value)
        {
            Username = value;
        }

  
    }
}
