using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmojiNote.Services
{
    interface NoteInterface<T>
    {
        Task<bool> AddNoteAsync(T item);
        Task<bool> UpdateNoteAsync(T item);
        Task<bool> DeleteNoteAsync(string id);
        Task<T> GetNoteAsync(string id);
        Task<IEnumerable<T>> GetNotesAsync(bool forceRefresh = false);
    }
}
