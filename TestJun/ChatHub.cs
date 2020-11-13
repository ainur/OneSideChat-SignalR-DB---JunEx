using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestJun.Interfaces;
using TestJun.Models;
using TestJun.Repositories;

namespace TestJun
{
    public class ChatHub : Hub
    {
        private readonly IMessageRepo repo;
        
        public ChatHub(IMessageRepo msgRepo)
        {
            repo = msgRepo;
        }
        public async Task Send(string message)
        {
            Message msg = new Message();
            msg.Text = message + "\n";
            await repo.AddMessage(msg);
            
            IEnumerable<Message> enumerable = await repo.GetMessages();
            IEnumerable<Message> innerMessages = enumerable;
            List<string> messages = new List<string>();
            foreach (Message m in innerMessages)
            {
                messages.Add(m.Text);
            }

            for (int i = 0; i < messages.Count; i++)
            {
                await Clients.All.SendAsync("Send", messages[i]);
            }
            
        }
        


    }
}
