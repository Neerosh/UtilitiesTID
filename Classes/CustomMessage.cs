using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Classes
{
    public class CustomMessage {
        string message, title, type;

        public string Message { get => message; set => message = value; }
        public string Type { get => type; set => type = value; }
        public string Title { get => title; set => title = value; }

        public CustomMessage() {
            Message = "";
            Title = "";
            Type = "";
        }

        public CustomMessage(string message,string title, string type) { 
            Message = message;
            Title = title;
            Type = type;    
        }
    }
}
