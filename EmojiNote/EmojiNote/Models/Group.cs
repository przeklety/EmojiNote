using System;
using System.Collections.Generic;
using System.Text;

namespace EmojiNote.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Emoji { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public List<Note> notes { get; set; }
    }
}
