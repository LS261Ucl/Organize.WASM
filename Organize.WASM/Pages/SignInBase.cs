using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Shared.Enitites;
using Organize.Business;
using Organize.Shared.Contracts;

namespace Organize.WASM.Pages
{
    public class SignInBase: SignBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        private IUserManager UserManager { get; set; }

        protected  async void Onsubmit()
        {
            if(!EditContext.Validate())
            {
                return;
            }
          
            var foundUser =  await UserManager.TrySignInAndGetUserAsync(User);

            if(foundUser != null)
            {
                NavigationManager.NavigateTo("items");
            }


        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            User = new User
            {
                FirstName = "x",
                LastName = "x",
                PhoneNumber = "123"
            };

            EditContext = new EditContext(User);
        }
        //protected string Username { get; set; } = "Lene";

        //protected void HandleUserNameChanged(ChangeEventArgs eventArgs)
        //{
        //    Username = eventArgs.Value.ToString();
        //}

        //protected void HandleUserNameValueChanged(string value)
        //{
        //    Username = value;
        //}


    }
}
