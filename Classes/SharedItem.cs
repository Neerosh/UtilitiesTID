using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Classes
{
    internal class SharedItem
    {
        string host, accessedBy, type, accessType, itemPath;
        long id;
        int locks;

        public string Host { get => host; set => host = value; }
        public string AccessedBy { get => accessedBy; set => accessedBy = value; }
        public string Type { get => type; set => type = value; }
        public string AccessType { get => accessType; set => accessType = value; }
        public string ItemPath { get => itemPath; set => itemPath = value; }
        public long Id { get => id;}
        public int Locks { get => locks; set => locks = value; }

        public SharedItem(string host, long id, string accessedBy, string type, int locks, string accessType, string itemPath) {
            this.id = id;
            Host = host;
            AccessedBy = accessedBy;
            Type = type;
            AccessType = accessType;
            ItemPath = itemPath;
            Locks = locks;
        }

    }
}
