
using Organize.Shared.Enitites;

namespace Organize.Shared.Contracts
{
   public interface IcurrentUserService
   {
         User CurrentUser { get; set; }
   }
}
