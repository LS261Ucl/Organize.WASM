using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organize.Shared.Enitites;
using Organize.Shared.Enums;

namespace Organize.Shared.Contracts
{
    public interface IUserItemManager
    {
        Task RetrieveAllUserItemsOfUserAndSetToUserAsync(User user);


        Task<ChildItem> CreateNewChildItemAndAddItToParentItemAsync(ParentItem parent);

        Task<BaseItem> CreateNewUserItemAndAddItToUserAsync(User user, ItemTypeEnum typeEnum);

        Task UpdateAsync<T>(T item) where T : BaseItem;

        Task DeleteAllDoneAsync(User user);
    }
}
