using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestJun.Interfaces;
using TestJun.Models;

namespace TestJun.Repositories
{
    class MessageRepo : IMessageRepo
    {
        private readonly DataContext _context;

        public MessageRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> AddMessage(Message message)
        {
            message.Created = DateTime.Now;
            
            _context.Messages.Add(message);
            return await _context.SaveChangesAsync() > 0;

        }
        public async Task<IEnumerable<Message>> GetMessages()
        {
            return await _context.Messages.ToListAsync();
            
        }
    }
}
