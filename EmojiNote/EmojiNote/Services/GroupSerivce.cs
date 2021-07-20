using EmojiNote.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace EmojiNote.Services
{
    class GroupSerivce : GroupInterface<Group>
    {
        readonly List<Group> groups;

        public GroupSerivce()
        {
            groups = new List<Group>()
            {
                new Group { Id = "0", Emoji = "a", Description="hah", Text="wow"},
                new Group { Id = "1", Emoji = "b", Description="hah", Text="wow" },
                new Group { Id = "3", Emoji = "c", Description="hah", Text="wow" },
            };
        }

        public async Task<bool> AddGroupAsync(Group group)
        {
            groups.Add(group);
            return await Task.FromResult(true);
        }              

        public async Task<bool> DeleteGroupAsync(string id)
        {
            var oldGroup = groups.Where(x => x.Id == id).FirstOrDefault();
            groups.Remove(oldGroup);
            return await Task.FromResult(true);
        }

        public async Task<Group> GetGroupAsync(string id)
        {
            var group = groups.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(group);
        }

        public async Task<IEnumerable<Group>> GetGroupsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(groups);
        }

        public async Task<bool> UpdateGroupAsync(Group group)
        {
            var oldGroup = groups.Where(x => x.Id == group.Id).FirstOrDefault();
            groups.Remove(oldGroup);
            groups.Add(group);
            return await Task.FromResult(true);
        }
    }
}
