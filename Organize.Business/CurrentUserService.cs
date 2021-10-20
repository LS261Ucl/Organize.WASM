using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organize.Shared.Contracts;
using Organize.Shared.Enitites;

namespace Organize.Business
{
    public class CurrentUserService : IcurrentUserService
    {
        public User CurrentUser { get; set; }
    }
}
