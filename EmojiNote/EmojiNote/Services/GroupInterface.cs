using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmojiNote.Services
{
    interface GroupInterface<T>
    {
        Task<bool> AddGroupAsync(T item);
        Task<bool> UpdateGroupAsync(T item);
        Task<bool> DeleteGroupAsync(string id);
        Task<T> GetGroupAsync(string id);
        Task<IEnumerable<T>> GetGroupsAsync(bool forceRefresh = false);
    }
}
