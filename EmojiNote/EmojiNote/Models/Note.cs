using System;
using System.Collections.Generic;
using System.Text;

namespace EmojiNote.Models
{
    public class Note
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public Group group { get; set; }
    }
}
