using EmojiNote.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EmojiNote.Services
{
    class NoteService : NoteInterface<Note>
    {
        readonly Group group;
        List<Note> notes;

        public NoteService()
        {
            notes = group.notes;
        }

        public async Task<bool> AddNoteAsync(Note item)
        {
            notes.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteNoteAsync(string id)
        {
            var note = notes.Where(x => x.Id == id).FirstOrDefault();
            notes.Remove(note);
            return await Task.FromResult(true);
        }

        public async Task<Note> GetNoteAsync(string id)
        {
            var note = notes.Where(x => x.Id == id).FirstOrDefault();
            return await Task.FromResult(note);
        }

        public async Task<IEnumerable<Note>> GetNotesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(notes);
        }

        public async Task<bool> UpdateNoteAsync(Note item)
        {
            var oldNote = notes.FirstOrDefault(x => x.Id == item.Id);
            notes.Remove(oldNote);
            notes.Add(item);
            return await Task.FromResult(true);
        }
    }
}
