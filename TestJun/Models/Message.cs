using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestJun.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
    }
}
