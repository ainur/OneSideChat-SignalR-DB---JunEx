using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestJun.Models;

namespace TestJun.Interfaces
{
    public interface IMessageRepo
    {
        Task<IEnumerable<Message>> GetMessages();
        Task<bool> AddMessage(Message message);
    }
}
