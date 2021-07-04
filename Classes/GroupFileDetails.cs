using System.Collections.Generic;
using System.Linq;

namespace Teste {
    class GroupFileDetails {

        private readonly List<FileDetails> list;

        public GroupFileDetails(FileDetails fileDetails) { list = new List<FileDetails> { fileDetails }; }

        public void AddFileDetail(FileDetails fileDetails) { list.Add(fileDetails); }

        public int ListCount() { return list.Count(); }

        public FileDetails GetFile(int ident) { return list[ident]; }

    }
}
