using Microsoft.AspNetCore.Components;
using MrjSite.Data;
using MrjSite.Model;

namespace MrjSite.Service
{
    public class AddMessageService
    {
       private readonly XDbContext _context;
        public AddMessageService(XDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddMessage(MessageViewModel c)
        {
            await _context.AddAsync( new Message
            {
                Name = c.Name,
                Email = c.Email,
                Subject = c.Subject,
                Text = c.Text,
            });
            return await _context.SaveChangesAsync()>0;
           
        }

    }
}
