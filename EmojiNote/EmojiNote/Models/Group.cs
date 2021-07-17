using System;
using System.Collections.Generic;
using System.Text;

namespace EmojiNote.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Emoji { get; set; }
        public List<Note> notes { get; set; }
    }
}
