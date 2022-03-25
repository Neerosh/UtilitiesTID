using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Classes
{
    internal class User
    {
        private string name, status;
        public string Name { get { return name; } }
        public string Status { get { return status; } }

        public User(string name, string status) {
            this.name = name;
            this.status = status;
        }

     }
}
